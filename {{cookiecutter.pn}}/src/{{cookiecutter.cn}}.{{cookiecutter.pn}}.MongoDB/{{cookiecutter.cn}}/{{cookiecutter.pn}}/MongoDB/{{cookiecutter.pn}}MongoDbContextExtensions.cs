using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}.MongoDB
{
    public static class {{cookiecutter.pn}}MongoDbContextExtensions
    {
        public static void Configure{{cookiecutter.pn}}(
            this IMongoModelBuilder builder,
            Action<MongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new {{cookiecutter.pn}}MongoModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);
        }
    }
}