using Microsoft.Extensions.DependencyInjection;
using {{cookiecutter.cn}}.{{cookiecutter.pn}}.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}
{
    [DependsOn(
        typeof({{cookiecutter.pn}}DomainSharedModule)
        )]
    public class {{cookiecutter.pn}}DomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<{{cookiecutter.pn}}DomainModule>();
            });

            context.Services.Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Get<{{cookiecutter.pn}}Resource>().AddVirtualJson("/{{cookiecutter.cn}}/{{cookiecutter.pn}}/Localization/Domain");
            });

            context.Services.Configure<ExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("{{cookiecutter.pn}}", typeof({{cookiecutter.pn}}Resource));
            });
        }
    }
}
