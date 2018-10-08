using {{MyCompanyName}}.{{MyProjectName}}.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace {{MyCompanyName}}.{{MyProjectName}}
{
    [DependsOn(
        typeof({{MyProjectName}}EntityFrameworkCoreTestModule)
        )]
    public class {{MyProjectName}}DomainTestModule : AbpModule
    {
        
    }
}
