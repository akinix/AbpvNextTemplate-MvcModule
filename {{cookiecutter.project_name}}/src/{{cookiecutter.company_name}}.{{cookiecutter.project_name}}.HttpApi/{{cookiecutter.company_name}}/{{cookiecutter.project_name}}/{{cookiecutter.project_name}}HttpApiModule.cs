using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}
{
    [DependsOn(
        typeof({{cookiecutter.project_name}}ApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class {{cookiecutter.project_name}}HttpApiModule : AbpModule
    {
        
    }
}
