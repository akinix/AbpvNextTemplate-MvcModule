using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}
{
    [DependsOn(
        typeof({{cookiecutter.pname}}ApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class {{cookiecutter.pname}}HttpApiModule : AbpModule
    {
        
    }
}
