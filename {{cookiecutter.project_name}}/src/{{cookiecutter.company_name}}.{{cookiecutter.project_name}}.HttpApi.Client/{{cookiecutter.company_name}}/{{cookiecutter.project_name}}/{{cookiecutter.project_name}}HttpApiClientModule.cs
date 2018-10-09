using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}
{
    [DependsOn(
        typeof({{cookiecutter.project_name}}ApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class {{cookiecutter.project_name}}HttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "{{cookiecutter.project_name}}";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof({{cookiecutter.project_name}}ApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
