using Volo.Abp.Modularity;

namespace {{MyCompanyName}}.{{MyProjectName}}
{
    [DependsOn(
        typeof({{MyProjectName}}ApplicationModule),
        typeof({{MyProjectName}}DomainTestModule)
        )]
    public class {{MyProjectName}}ApplicationTestModule : AbpModule
    {

    }
}
