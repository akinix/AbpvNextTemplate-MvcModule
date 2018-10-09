using Microsoft.Extensions.DependencyInjection;
using {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}
{
    [DependsOn(
        typeof({{cookiecutter.project_name}}DomainSharedModule)
        )]
    public class {{cookiecutter.project_name}}DomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<{{cookiecutter.project_name}}DomainModule>();
            });

            context.Services.Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Get<{{cookiecutter.project_name}}Resource>().AddVirtualJson("/{{cookiecutter.company_name}}/{{cookiecutter.project_name}}/Localization/Domain");
            });

            context.Services.Configure<ExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("{{cookiecutter.project_name}}", typeof({{cookiecutter.project_name}}Resource));
            });
        }
    }
}
