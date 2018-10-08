using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace {{MyCompanyName}}.{{MyProjectName}}.MongoDB
{
    public class {{MyProjectName}}MongoModelBuilderConfigurationOptions : MongoModelBuilderConfigurationOptions
    {
        public {{MyProjectName}}MongoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = {{MyProjectName}}Consts.DefaultDbTablePrefix)
            : base(tablePrefix)
        {
        }
    }
}