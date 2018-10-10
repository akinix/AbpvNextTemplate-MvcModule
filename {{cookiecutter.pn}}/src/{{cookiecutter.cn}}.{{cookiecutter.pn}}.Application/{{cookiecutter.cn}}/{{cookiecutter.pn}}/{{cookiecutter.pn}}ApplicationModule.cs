using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Settings;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}
{
    [DependsOn(
        typeof({{cookiecutter.pn}}DomainModule),
        typeof({{cookiecutter.pn}}ApplicationContractsModule),
        typeof(AbpAutoMapperModule)
        )]
    public class {{cookiecutter.pn}}ApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<{{cookiecutter.pn}}ApplicationAutoMapperProfile>(validate: true);
            });

            context.Services.Configure<SettingOptions>(options =>
            {
                options.DefinitionProviders.Add<{{cookiecutter.pn}}SettingDefinitionProvider>();
            });
        }
    }
}
