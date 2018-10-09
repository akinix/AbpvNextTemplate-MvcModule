using Microsoft.Extensions.DependencyInjection;
using Mongo2Go;
using Volo.Abp;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.MongoDB
{
    [DependsOn(
        typeof({{cookiecutter.project_name}}TestBaseModule),
        typeof({{cookiecutter.project_name}}MongoDbModule)
        )]
    public class {{cookiecutter.project_name}}MongoDbTestModule : AbpModule
    {
        private MongoDbRunner _mongoDbRunner;

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            _mongoDbRunner = MongoDbRunner.Start();

            context.Services.Configure<DbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = _mongoDbRunner.ConnectionString;
            });
        }

        public override void OnApplicationShutdown(ApplicationShutdownContext context)
        {
            _mongoDbRunner.Dispose();
        }
    }
}