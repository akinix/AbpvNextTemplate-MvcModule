using Microsoft.Extensions.DependencyInjection;
using {{cookiecutter.cname}}.{{cookiecutter.pname}}.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}
{
    [DependsOn(
        typeof({{cookiecutter.pname}}DomainSharedModule)
        )]
    public class {{cookiecutter.pname}}DomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<{{cookiecutter.pname}}DomainModule>();
            });

            context.Services.Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Get<{{cookiecutter.pname}}Resource>().AddVirtualJson("/{{cookiecutter.cname}}/{{cookiecutter.pname}}/Localization/Domain");
            });

            context.Services.Configure<ExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("{{cookiecutter.pname}}", typeof({{cookiecutter.pname}}Resource));
            });
        }
    }
}
