using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace {{MyCompanyName}}.{{MyProjectName}}.EntityFrameworkCore
{
    [ConnectionStringName("{{MyProjectName}}")]
    public class {{MyProjectName}}DbContext : AbpDbContext<{{MyProjectName}}DbContext>, I{{MyProjectName}}DbContext
    {
        public static string TablePrefix { get; set; } = {{MyProjectName}}Consts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = {{MyProjectName}}Consts.DefaultDbSchema;

        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public {{MyProjectName}}DbContext(DbContextOptions<{{MyProjectName}}DbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Configure{{MyProjectName}}(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });
        }
    }
}