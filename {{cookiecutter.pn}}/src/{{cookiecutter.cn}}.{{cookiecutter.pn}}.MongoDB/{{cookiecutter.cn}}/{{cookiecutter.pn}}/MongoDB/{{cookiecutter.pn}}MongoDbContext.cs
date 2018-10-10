using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}.MongoDB
{
    [ConnectionStringName("{{cookiecutter.pn}}")]
    public class {{cookiecutter.pn}}MongoDbContext : AbpMongoDbContext, I{{cookiecutter.pn}}MongoDbContext
    {
        public static string CollectionPrefix { get; set; } = {{cookiecutter.pn}}Consts.DefaultDbTablePrefix;

        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.Configure{{cookiecutter.pn}}(options =>
            {
                options.CollectionPrefix = CollectionPrefix;
            });
        }
    }
}