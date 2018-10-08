using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace {{MyCompanyName}}.{{MyProjectName}}.EntityFrameworkCore
{
    [DependsOn(
        typeof({{MyProjectName}}DomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class {{MyProjectName}}EntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<{{MyProjectName}}DbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}