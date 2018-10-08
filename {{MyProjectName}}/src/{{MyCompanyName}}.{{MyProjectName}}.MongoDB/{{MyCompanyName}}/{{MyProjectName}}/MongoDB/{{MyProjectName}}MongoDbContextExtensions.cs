using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace {{MyCompanyName}}.{{MyProjectName}}.MongoDB
{
    public static class {{MyProjectName}}MongoDbContextExtensions
    {
        public static void Configure{{MyProjectName}}(
            this IMongoModelBuilder builder,
            Action<MongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new {{MyProjectName}}MongoModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);
        }
    }
}