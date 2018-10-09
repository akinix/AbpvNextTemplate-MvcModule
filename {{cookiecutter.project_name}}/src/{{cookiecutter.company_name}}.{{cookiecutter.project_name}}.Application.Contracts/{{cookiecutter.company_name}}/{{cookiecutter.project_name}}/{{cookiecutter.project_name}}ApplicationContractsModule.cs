using Microsoft.Extensions.DependencyInjection;
using {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.Localization;
using Volo.Abp.Application;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}
{
    [DependsOn(
        typeof({{cookiecutter.project_name}}DomainSharedModule),
        typeof(AbpDddApplicationModule)
        )]
    public class {{cookiecutter.project_name}}ApplicationContractsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<PermissionOptions>(options =>
            {
                options.DefinitionProviders.Add<{{cookiecutter.project_name}}PermissionDefinitionProvider>();
            });

            context.Services.Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<{{cookiecutter.project_name}}ApplicationContractsModule>();
            });

            context.Services.Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<{{cookiecutter.project_name}}Resource>()
                    .AddVirtualJson("/{{cookiecutter.company_name}}/{{cookiecutter.project_name}}/Localization/ApplicationContracts");
            });
        }
    }
}
