using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace {{MyCompanyName}}.{{MyProjectName}}
{
    [DependsOn(
        typeof({{MyProjectName}}ApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class {{MyProjectName}}HttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "{{MyProjectName}}";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof({{MyProjectName}}ApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
