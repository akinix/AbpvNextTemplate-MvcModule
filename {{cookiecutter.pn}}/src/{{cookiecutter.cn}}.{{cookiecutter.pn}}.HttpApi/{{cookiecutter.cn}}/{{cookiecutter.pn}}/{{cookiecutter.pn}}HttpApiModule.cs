using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}
{
    [DependsOn(
        typeof({{cookiecutter.pn}}ApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class {{cookiecutter.pn}}HttpApiModule : AbpModule
    {
        
    }
}
