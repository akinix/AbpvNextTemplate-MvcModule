using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace {{MyCompanyName}}.{{MyProjectName}}.MongoDB
{
    [ConnectionStringName("{{MyProjectName}}")]
    public class {{MyProjectName}}MongoDbContext : AbpMongoDbContext, I{{MyProjectName}}MongoDbContext
    {
        public static string CollectionPrefix { get; set; } = {{MyProjectName}}Consts.DefaultDbTablePrefix;

        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.Configure{{MyProjectName}}(options =>
            {
                options.CollectionPrefix = CollectionPrefix;
            });
        }
    }
}