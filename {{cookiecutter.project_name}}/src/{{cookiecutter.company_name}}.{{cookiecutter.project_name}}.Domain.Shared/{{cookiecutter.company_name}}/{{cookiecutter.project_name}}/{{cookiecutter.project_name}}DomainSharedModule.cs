using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.Localization;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}
{
    [DependsOn(
        typeof(AbpLocalizationModule)
        )]
    public class {{cookiecutter.project_name}}DomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Add<{{cookiecutter.project_name}}Resource>("en");
            });
        }
    }
}
