using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Settings;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}
{
    [DependsOn(
        typeof({{cookiecutter.project_name}}DomainModule),
        typeof({{cookiecutter.project_name}}ApplicationContractsModule),
        typeof(AbpAutoMapperModule)
        )]
    public class {{cookiecutter.project_name}}ApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<{{cookiecutter.project_name}}ApplicationAutoMapperProfile>(validate: true);
            });

            context.Services.Configure<SettingOptions>(options =>
            {
                options.DefinitionProviders.Add<{{cookiecutter.project_name}}SettingDefinitionProvider>();
            });
        }
    }
}
