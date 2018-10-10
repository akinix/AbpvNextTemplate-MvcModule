using Microsoft.Extensions.DependencyInjection;
using {{cookiecutter.cn}}.{{cookiecutter.pn}}.Localization;
using Volo.Abp.Application;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}
{
    [DependsOn(
        typeof({{cookiecutter.pn}}DomainSharedModule),
        typeof(AbpDddApplicationModule)
        )]
    public class {{cookiecutter.pn}}ApplicationContractsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<PermissionOptions>(options =>
            {
                options.DefinitionProviders.Add<{{cookiecutter.pn}}PermissionDefinitionProvider>();
            });

            context.Services.Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<{{cookiecutter.pn}}ApplicationContractsModule>();
            });

            context.Services.Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<{{cookiecutter.pn}}Resource>()
                    .AddVirtualJson("/{{cookiecutter.cn}}/{{cookiecutter.pn}}/Localization/ApplicationContracts");
            });
        }
    }
}
