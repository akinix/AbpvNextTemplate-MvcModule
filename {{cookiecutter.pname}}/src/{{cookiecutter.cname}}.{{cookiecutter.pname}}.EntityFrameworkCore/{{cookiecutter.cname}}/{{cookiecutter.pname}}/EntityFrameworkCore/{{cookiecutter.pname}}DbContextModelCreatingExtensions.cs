using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}.EntityFrameworkCore
{
    public static class {{cookiecutter.pname}}DbContextModelCreatingExtensions
    {
        public static void Configure{{cookiecutter.pname}}(
            this ModelBuilder builder,
            Action<{{cookiecutter.pname}}ModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new {{cookiecutter.pname}}ModelBuilderConfigurationOptions();

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