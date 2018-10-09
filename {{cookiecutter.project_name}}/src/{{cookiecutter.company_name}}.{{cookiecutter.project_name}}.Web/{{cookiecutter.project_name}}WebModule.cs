using Localization.Resources.AbpUi;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.Localization;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap;
using Volo.Abp.AutoMapper;
using Volo.Abp.Localization;
using Volo.Abp.Localization.Resources.AbpValidation;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using Volo.Abp.VirtualFileSystem;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}
{
    [DependsOn(typeof({{cookiecutter.project_name}}HttpApiModule))]
    [DependsOn(typeof(AbpAspNetCoreMvcUiBootstrapModule))]
    [DependsOn(typeof(AbpAutoMapperModule))]
    public class {{cookiecutter.project_name}}WebModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
            {
                options.AddAssemblyResource(typeof({{cookiecutter.project_name}}Resource), typeof({{cookiecutter.project_name}}WebModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<NavigationOptions>(options =>
            {
                options.MenuContributors.Add(new {{cookiecutter.project_name}}MenuContributor());
            });

            context.Services.Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<{{cookiecutter.project_name}}WebModule>("{{cookiecutter.company_name}}.{{cookiecutter.project_name}}");
            });

            context.Services.Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<{{cookiecutter.project_name}}Resource>()
                    .AddBaseTypes(
                        typeof(AbpValidationResource),
                        typeof(AbpUiResource)
                    ).AddVirtualJson("/Localization/Resources/{{cookiecutter.project_name}}");
            });

            context.Services.Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<{{cookiecutter.project_name}}WebAutoMapperProfile>(validate: true);
            });

            context.Services.Configure<RazorPagesOptions>(options =>
            {
                //Configure authorization.
            });
        }
    }
}
