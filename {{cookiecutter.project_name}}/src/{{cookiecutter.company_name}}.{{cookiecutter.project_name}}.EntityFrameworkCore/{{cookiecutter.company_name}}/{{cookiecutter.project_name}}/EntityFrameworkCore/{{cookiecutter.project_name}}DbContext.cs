using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.EntityFrameworkCore
{
    [ConnectionStringName("{{cookiecutter.project_name}}")]
    public class {{cookiecutter.project_name}}DbContext : AbpDbContext<{{cookiecutter.project_name}}DbContext>, I{{cookiecutter.project_name}}DbContext
    {
        public static string TablePrefix { get; set; } = {{cookiecutter.project_name}}Consts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = {{cookiecutter.project_name}}Consts.DefaultDbSchema;

        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public {{cookiecutter.project_name}}DbContext(DbContextOptions<{{cookiecutter.project_name}}DbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Configure{{cookiecutter.project_name}}(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });
        }
    }
}