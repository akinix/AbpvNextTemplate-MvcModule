using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.MongoDB
{
    [DependsOn(
        typeof({{cookiecutter.project_name}}DomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class {{cookiecutter.project_name}}MongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            {{cookiecutter.project_name}}BsonClassMap.Configure();

            context.Services.AddMongoDbContext<{{cookiecutter.project_name}}MongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
