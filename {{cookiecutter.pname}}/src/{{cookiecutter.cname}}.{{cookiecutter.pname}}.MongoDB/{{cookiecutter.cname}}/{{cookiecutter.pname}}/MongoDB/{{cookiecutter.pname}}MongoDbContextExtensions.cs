using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}.MongoDB
{
    public static class {{cookiecutter.pname}}MongoDbContextExtensions
    {
        public static void Configure{{cookiecutter.pname}}(
            this IMongoModelBuilder builder,
            Action<MongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new {{cookiecutter.pname}}MongoModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);
        }
    }
}