using Microsoft.Extensions.DependencyInjection;
using {{cookiecutter.cname}}.{{cookiecutter.pname}}.Localization;
using Volo.Abp.Application;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}
{
    [DependsOn(
        typeof({{cookiecutter.pname}}DomainSharedModule),
        typeof(AbpDddApplicationModule)
        )]
    public class {{cookiecutter.pname}}ApplicationContractsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<PermissionOptions>(options =>
            {
                options.DefinitionProviders.Add<{{cookiecutter.pname}}PermissionDefinitionProvider>();
            });

            context.Services.Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<{{cookiecutter.pname}}ApplicationContractsModule>();
            });

            context.Services.Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<{{cookiecutter.pname}}Resource>()
                    .AddVirtualJson("/{{cookiecutter.cname}}/{{cookiecutter.pname}}/Localization/ApplicationContracts");
            });
        }
    }
}
