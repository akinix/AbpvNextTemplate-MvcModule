using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.MongoDB
{
    [ConnectionStringName("{{cookiecutter.project_name}}")]
    public interface I{{cookiecutter.project_name}}MongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
