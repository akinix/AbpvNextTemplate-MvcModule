using Volo.Abp.Modularity;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}
{
    [DependsOn(
        typeof({{cookiecutter.pn}}ApplicationModule),
        typeof({{cookiecutter.pn}}DomainTestModule)
        )]
    public class {{cookiecutter.pn}}ApplicationTestModule : AbpModule
    {

    }
}
