using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}.MongoDB
{
    [ConnectionStringName("{{cookiecutter.pname}}")]
    public class {{cookiecutter.pname}}MongoDbContext : AbpMongoDbContext, I{{cookiecutter.pname}}MongoDbContext
    {
        public static string CollectionPrefix { get; set; } = {{cookiecutter.pname}}Consts.DefaultDbTablePrefix;

        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.Configure{{cookiecutter.pname}}(options =>
            {
                options.CollectionPrefix = CollectionPrefix;
            });
        }
    }
}