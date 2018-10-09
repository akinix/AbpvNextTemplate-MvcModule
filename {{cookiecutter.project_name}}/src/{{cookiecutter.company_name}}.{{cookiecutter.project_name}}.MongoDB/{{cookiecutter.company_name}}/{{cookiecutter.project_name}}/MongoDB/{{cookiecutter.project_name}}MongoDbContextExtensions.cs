using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.MongoDB
{
    public static class {{cookiecutter.project_name}}MongoDbContextExtensions
    {
        public static void Configure{{cookiecutter.project_name}}(
            this IMongoModelBuilder builder,
            Action<MongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new {{cookiecutter.project_name}}MongoModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);
        }
    }
}