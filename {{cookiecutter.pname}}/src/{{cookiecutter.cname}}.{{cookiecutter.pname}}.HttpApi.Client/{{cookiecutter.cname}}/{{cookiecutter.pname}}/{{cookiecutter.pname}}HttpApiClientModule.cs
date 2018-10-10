using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}
{
    [DependsOn(
        typeof({{cookiecutter.pname}}ApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class {{cookiecutter.pname}}HttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "{{cookiecutter.pname}}";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof({{cookiecutter.pname}}ApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
