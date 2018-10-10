using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}.EntityFrameworkCore
{
    public static class {{cookiecutter.pn}}DbContextModelCreatingExtensions
    {
        public static void Configure{{cookiecutter.pn}}(
            this ModelBuilder builder,
            Action<{{cookiecutter.pn}}ModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new {{cookiecutter.pn}}ModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                //b.ToTable(options.TablePrefix + "Questions", options.Schema);
                
                //Properties
                //b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Configure relations
                //b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Configure indexes
                //b.HasIndex(q => q.CreationTime);
            });
            */
        }
    }
}