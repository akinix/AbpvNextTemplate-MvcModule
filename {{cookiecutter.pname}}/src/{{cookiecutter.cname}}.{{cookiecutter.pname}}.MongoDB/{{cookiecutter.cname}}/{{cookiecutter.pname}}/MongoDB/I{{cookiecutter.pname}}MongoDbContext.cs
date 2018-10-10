using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}.MongoDB
{
    [ConnectionStringName("{{cookiecutter.pname}}")]
    public interface I{{cookiecutter.pname}}MongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
