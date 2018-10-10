using Volo.Abp.Modularity;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}
{
    [DependsOn(
        typeof({{cookiecutter.pname}}ApplicationModule),
        typeof({{cookiecutter.pname}}DomainTestModule)
        )]
    public class {{cookiecutter.pname}}ApplicationTestModule : AbpModule
    {

    }
}
