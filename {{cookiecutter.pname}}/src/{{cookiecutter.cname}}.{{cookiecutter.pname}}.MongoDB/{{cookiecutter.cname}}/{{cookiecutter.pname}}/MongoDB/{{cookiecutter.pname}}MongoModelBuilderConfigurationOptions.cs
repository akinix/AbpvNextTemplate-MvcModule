using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}.MongoDB
{
    public class {{cookiecutter.pname}}MongoModelBuilderConfigurationOptions : MongoModelBuilderConfigurationOptions
    {
        public {{cookiecutter.pname}}MongoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = {{cookiecutter.pname}}Consts.DefaultDbTablePrefix)
            : base(tablePrefix)
        {
        }
    }
}