using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace {{MyCompanyName}}.{{MyProjectName}}
{
    [DependsOn(
        typeof({{MyProjectName}}ApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class {{MyProjectName}}HttpApiModule : AbpModule
    {
        
    }
}
