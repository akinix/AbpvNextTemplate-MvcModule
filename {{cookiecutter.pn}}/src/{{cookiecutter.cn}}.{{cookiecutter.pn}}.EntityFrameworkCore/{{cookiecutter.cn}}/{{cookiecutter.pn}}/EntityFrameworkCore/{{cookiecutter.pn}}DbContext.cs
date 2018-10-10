using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}.EntityFrameworkCore
{
    [ConnectionStringName("{{cookiecutter.pn}}")]
    public class {{cookiecutter.pn}}DbContext : AbpDbContext<{{cookiecutter.pn}}DbContext>, I{{cookiecutter.pn}}DbContext
    {
        public static string TablePrefix { get; set; } = {{cookiecutter.pn}}Consts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = {{cookiecutter.pn}}Consts.DefaultDbSchema;

        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public {{cookiecutter.pn}}DbContext(DbContextOptions<{{cookiecutter.pn}}DbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Configure{{cookiecutter.pn}}(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });
        }
    }
}