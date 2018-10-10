using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}.EntityFrameworkCore
{
    public class {{cookiecutter.pname}}ModelBuilderConfigurationOptions : ModelBuilderConfigurationOptions
    {
        public {{cookiecutter.pname}}ModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = {{cookiecutter.pname}}Consts.DefaultDbTablePrefix,
            [CanBeNull] string schema = {{cookiecutter.pname}}Consts.DefaultDbSchema)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}