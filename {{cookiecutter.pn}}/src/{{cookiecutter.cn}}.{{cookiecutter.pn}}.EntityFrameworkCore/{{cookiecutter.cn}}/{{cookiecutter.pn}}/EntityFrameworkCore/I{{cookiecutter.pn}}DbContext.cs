using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}.EntityFrameworkCore
{
    [ConnectionStringName("{{cookiecutter.pn}}")]
    public interface I{{cookiecutter.pn}}DbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}