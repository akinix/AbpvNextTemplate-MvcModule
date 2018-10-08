using Microsoft.Extensions.DependencyInjection;
using {{MyCompanyName}}.{{MyProjectName}}.Localization;
using Volo.Abp.Application;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace {{MyCompanyName}}.{{MyProjectName}}
{
    [DependsOn(
        typeof({{MyProjectName}}DomainSharedModule),
        typeof(AbpDddApplicationModule)
        )]
    public class {{MyProjectName}}ApplicationContractsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<PermissionOptions>(options =>
            {
                options.DefinitionProviders.Add<{{MyProjectName}}PermissionDefinitionProvider>();
            });

            context.Services.Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<{{MyProjectName}}ApplicationContractsModule>();
            });

            context.Services.Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<{{MyProjectName}}Resource>()
                    .AddVirtualJson("/{{MyCompanyName}}/{{MyProjectName}}/Localization/ApplicationContracts");
            });
        }
    }
}
