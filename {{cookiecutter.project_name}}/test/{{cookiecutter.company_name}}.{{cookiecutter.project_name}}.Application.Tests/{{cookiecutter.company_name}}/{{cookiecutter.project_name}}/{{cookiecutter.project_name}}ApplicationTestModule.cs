using Volo.Abp.Modularity;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}
{
    [DependsOn(
        typeof({{cookiecutter.project_name}}ApplicationModule),
        typeof({{cookiecutter.project_name}}DomainTestModule)
        )]
    public class {{cookiecutter.project_name}}ApplicationTestModule : AbpModule
    {

    }
}
