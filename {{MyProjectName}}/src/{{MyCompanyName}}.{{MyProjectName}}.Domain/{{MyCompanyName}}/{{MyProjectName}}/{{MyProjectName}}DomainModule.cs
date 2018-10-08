using Microsoft.Extensions.DependencyInjection;
using {{MyCompanyName}}.{{MyProjectName}}.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace {{MyCompanyName}}.{{MyProjectName}}
{
    [DependsOn(
        typeof({{MyProjectName}}DomainSharedModule)
        )]
    public class {{MyProjectName}}DomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<{{MyProjectName}}DomainModule>();
            });

            context.Services.Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Get<{{MyProjectName}}Resource>().AddVirtualJson("/{{MyCompanyName}}/{{MyProjectName}}/Localization/Domain");
            });

            context.Services.Configure<ExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("{{MyProjectName}}", typeof({{MyProjectName}}Resource));
            });
        }
    }
}
