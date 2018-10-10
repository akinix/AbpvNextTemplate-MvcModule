using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}.MongoDB
{
    [DependsOn(
        typeof({{cookiecutter.pn}}DomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class {{cookiecutter.pn}}MongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            {{cookiecutter.pn}}BsonClassMap.Configure();

            context.Services.AddMongoDbContext<{{cookiecutter.pn}}MongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
