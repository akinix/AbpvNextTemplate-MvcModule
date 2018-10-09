using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.MongoDB
{
    public class {{cookiecutter.project_name}}MongoModelBuilderConfigurationOptions : MongoModelBuilderConfigurationOptions
    {
        public {{cookiecutter.project_name}}MongoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = {{cookiecutter.project_name}}Consts.DefaultDbTablePrefix)
            : base(tablePrefix)
        {
        }
    }
}