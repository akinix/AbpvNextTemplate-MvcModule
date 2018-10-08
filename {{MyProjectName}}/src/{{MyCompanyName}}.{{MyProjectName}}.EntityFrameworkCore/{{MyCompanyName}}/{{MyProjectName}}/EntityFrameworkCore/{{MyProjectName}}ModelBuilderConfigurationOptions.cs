using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace {{MyCompanyName}}.{{MyProjectName}}.EntityFrameworkCore
{
    public class {{MyProjectName}}ModelBuilderConfigurationOptions : ModelBuilderConfigurationOptions
    {
        public {{MyProjectName}}ModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = {{MyProjectName}}Consts.DefaultDbTablePrefix,
            [CanBeNull] string schema = {{MyProjectName}}Consts.DefaultDbSchema)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}