using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}.EntityFrameworkCore
{
    public class {{cookiecutter.pn}}ModelBuilderConfigurationOptions : ModelBuilderConfigurationOptions
    {
        public {{cookiecutter.pn}}ModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = {{cookiecutter.pn}}Consts.DefaultDbTablePrefix,
            [CanBeNull] string schema = {{cookiecutter.pn}}Consts.DefaultDbSchema)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}