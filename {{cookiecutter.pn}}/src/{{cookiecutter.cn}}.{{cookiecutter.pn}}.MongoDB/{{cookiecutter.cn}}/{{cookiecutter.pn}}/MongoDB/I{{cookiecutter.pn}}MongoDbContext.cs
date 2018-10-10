using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}.MongoDB
{
    [ConnectionStringName("{{cookiecutter.pn}}")]
    public interface I{{cookiecutter.pn}}MongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
