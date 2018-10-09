using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.EntityFrameworkCore
{
    public class {{cookiecutter.project_name}}ModelBuilderConfigurationOptions : ModelBuilderConfigurationOptions
    {
        public {{cookiecutter.project_name}}ModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = {{cookiecutter.project_name}}Consts.DefaultDbTablePrefix,
            [CanBeNull] string schema = {{cookiecutter.project_name}}Consts.DefaultDbSchema)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}