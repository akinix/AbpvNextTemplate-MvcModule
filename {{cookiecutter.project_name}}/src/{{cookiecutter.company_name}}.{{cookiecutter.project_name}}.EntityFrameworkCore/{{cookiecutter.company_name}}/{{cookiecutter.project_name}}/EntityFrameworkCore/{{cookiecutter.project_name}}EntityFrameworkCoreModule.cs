using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.EntityFrameworkCore
{
    [DependsOn(
        typeof({{cookiecutter.project_name}}DomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class {{cookiecutter.project_name}}EntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<{{cookiecutter.project_name}}DbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}