using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}.MongoDB
{
    public class {{cookiecutter.pn}}MongoModelBuilderConfigurationOptions : MongoModelBuilderConfigurationOptions
    {
        public {{cookiecutter.pn}}MongoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = {{cookiecutter.pn}}Consts.DefaultDbTablePrefix)
            : base(tablePrefix)
        {
        }
    }
}