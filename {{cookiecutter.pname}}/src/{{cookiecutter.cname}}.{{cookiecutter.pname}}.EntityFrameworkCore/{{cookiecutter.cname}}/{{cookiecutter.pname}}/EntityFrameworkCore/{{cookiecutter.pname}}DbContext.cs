using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}.EntityFrameworkCore
{
    [ConnectionStringName("{{cookiecutter.pname}}")]
    public class {{cookiecutter.pname}}DbContext : AbpDbContext<{{cookiecutter.pname}}DbContext>, I{{cookiecutter.pname}}DbContext
    {
        public static string TablePrefix { get; set; } = {{cookiecutter.pname}}Consts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = {{cookiecutter.pname}}Consts.DefaultDbSchema;

        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public {{cookiecutter.pname}}DbContext(DbContextOptions<{{cookiecutter.pname}}DbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Configure{{cookiecutter.pname}}(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });
        }
    }
}