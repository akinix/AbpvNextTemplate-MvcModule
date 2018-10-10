using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Settings;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}
{
    [DependsOn(
        typeof({{cookiecutter.pname}}DomainModule),
        typeof({{cookiecutter.pname}}ApplicationContractsModule),
        typeof(AbpAutoMapperModule)
        )]
    public class {{cookiecutter.pname}}ApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<{{cookiecutter.pname}}ApplicationAutoMapperProfile>(validate: true);
            });

            context.Services.Configure<SettingOptions>(options =>
            {
                options.DefinitionProviders.Add<{{cookiecutter.pname}}SettingDefinitionProvider>();
            });
        }
    }
}
