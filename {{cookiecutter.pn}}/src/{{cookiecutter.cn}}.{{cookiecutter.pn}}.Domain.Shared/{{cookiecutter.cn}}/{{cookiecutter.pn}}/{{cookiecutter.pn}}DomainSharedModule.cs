using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using {{cookiecutter.cn}}.{{cookiecutter.pn}}.Localization;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}
{
    [DependsOn(
        typeof(AbpLocalizationModule)
        )]
    public class {{cookiecutter.pn}}DomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Add<{{cookiecutter.pn}}Resource>("en");
            });
        }
    }
}
