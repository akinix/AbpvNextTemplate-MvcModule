using Localization.Resources.AbpUi;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using {{cookiecutter.cn}}.{{cookiecutter.pn}}.Localization;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap;
using Volo.Abp.AutoMapper;
using Volo.Abp.Localization;
using Volo.Abp.Localization.Resources.AbpValidation;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using Volo.Abp.VirtualFileSystem;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}
{
    [DependsOn(typeof({{cookiecutter.pn}}HttpApiModule))]
    [DependsOn(typeof(AbpAspNetCoreMvcUiBootstrapModule))]
    [DependsOn(typeof(AbpAutoMapperModule))]
    public class {{cookiecutter.pn}}WebModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
            {
                options.AddAssemblyResource(typeof({{cookiecutter.pn}}Resource), typeof({{cookiecutter.pn}}WebModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<NavigationOptions>(options =>
            {
                options.MenuContributors.Add(new {{cookiecutter.pn}}MenuContributor());
            });

            context.Services.Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<{{cookiecutter.pn}}WebModule>("{{cookiecutter.cn}}.{{cookiecutter.pn}}");
            });

            context.Services.Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<{{cookiecutter.pn}}Resource>()
                    .AddBaseTypes(
                        typeof(AbpValidationResource),
                        typeof(AbpUiResource)
                    ).AddVirtualJson("/Localization/Resources/{{cookiecutter.pn}}");
            });

            context.Services.Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<{{cookiecutter.pn}}WebAutoMapperProfile>(validate: true);
            });

            context.Services.Configure<RazorPagesOptions>(options =>
            {
                //Configure authorization.
            });
        }
    }
}
