using {{cookiecutter.cn}}.{{cookiecutter.pn}}.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}
{
    [DependsOn(
        typeof({{cookiecutter.pn}}EntityFrameworkCoreTestModule)
        )]
    public class {{cookiecutter.pn}}DomainTestModule : AbpModule
    {
        
    }
}
