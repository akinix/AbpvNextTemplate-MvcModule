using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace {{MyCompanyName}}.{{MyProjectName}}.MongoDB
{
    [DependsOn(
        typeof({{MyProjectName}}DomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class {{MyProjectName}}MongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            {{MyProjectName}}BsonClassMap.Configure();

            context.Services.AddMongoDbContext<{{MyProjectName}}MongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
