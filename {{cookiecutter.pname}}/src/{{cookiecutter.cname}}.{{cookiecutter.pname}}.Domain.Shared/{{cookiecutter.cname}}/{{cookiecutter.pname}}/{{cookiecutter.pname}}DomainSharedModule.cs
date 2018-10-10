using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using {{cookiecutter.cname}}.{{cookiecutter.pname}}.Localization;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}
{
    [DependsOn(
        typeof(AbpLocalizationModule)
        )]
    public class {{cookiecutter.pname}}DomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Add<{{cookiecutter.pname}}Resource>("en");
            });
        }
    }
}
