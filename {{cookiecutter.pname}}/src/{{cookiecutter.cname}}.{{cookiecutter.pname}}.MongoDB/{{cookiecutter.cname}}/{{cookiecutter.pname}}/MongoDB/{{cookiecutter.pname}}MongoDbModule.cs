using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}.MongoDB
{
    [DependsOn(
        typeof({{cookiecutter.pname}}DomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class {{cookiecutter.pname}}MongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            {{cookiecutter.pname}}BsonClassMap.Configure();

            context.Services.AddMongoDbContext<{{cookiecutter.pname}}MongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
