using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.MongoDB
{
    [ConnectionStringName("{{cookiecutter.project_name}}")]
    public class {{cookiecutter.project_name}}MongoDbContext : AbpMongoDbContext, I{{cookiecutter.project_name}}MongoDbContext
    {
        public static string CollectionPrefix { get; set; } = {{cookiecutter.project_name}}Consts.DefaultDbTablePrefix;

        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.Configure{{cookiecutter.project_name}}(options =>
            {
                options.CollectionPrefix = CollectionPrefix;
            });
        }
    }
}