using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.EntityFrameworkCore
{
    [ConnectionStringName("{{cookiecutter.project_name}}")]
    public interface I{{cookiecutter.project_name}}DbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}