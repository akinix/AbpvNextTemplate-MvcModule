using {{cookiecutter.cn}}.{{cookiecutter.pn}}.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}
{
    public class {{cookiecutter.pn}}PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup({{cookiecutter.pn}}Permissions.GroupName, L("Permission:{{cookiecutter.pn}}"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<{{cookiecutter.pn}}Resource>(name);
        }
    }
}