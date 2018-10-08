using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace {{MyCompanyName}}.{{MyProjectName}}.MongoDB
{
    [ConnectionStringName("{{MyProjectName}}")]
    public interface I{{MyProjectName}}MongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
