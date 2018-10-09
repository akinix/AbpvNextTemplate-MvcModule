using {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}
{
    [DependsOn(
        typeof({{cookiecutter.project_name}}EntityFrameworkCoreTestModule)
        )]
    public class {{cookiecutter.project_name}}DomainTestModule : AbpModule
    {
        
    }
}
