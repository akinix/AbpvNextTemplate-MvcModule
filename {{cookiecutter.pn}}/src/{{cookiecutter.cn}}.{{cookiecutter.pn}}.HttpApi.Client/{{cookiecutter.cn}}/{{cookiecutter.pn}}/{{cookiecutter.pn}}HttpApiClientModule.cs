using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}
{
    [DependsOn(
        typeof({{cookiecutter.pn}}ApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class {{cookiecutter.pn}}HttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "{{cookiecutter.pn}}";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof({{cookiecutter.pn}}ApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
