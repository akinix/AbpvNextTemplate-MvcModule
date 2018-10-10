using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}.EntityFrameworkCore
{
    [ConnectionStringName("{{cookiecutter.pname}}")]
    public interface I{{cookiecutter.pname}}DbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}