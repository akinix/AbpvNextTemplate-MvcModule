using {{cookiecutter.cname}}.{{cookiecutter.pname}}.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}
{
    [DependsOn(
        typeof({{cookiecutter.pname}}EntityFrameworkCoreTestModule)
        )]
    public class {{cookiecutter.pname}}DomainTestModule : AbpModule
    {
        
    }
}
