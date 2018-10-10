using {{cookiecutter.cname}}.{{cookiecutter.pname}}.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}
{
    public class {{cookiecutter.pname}}PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup({{cookiecutter.pname}}Permissions.GroupName, L("Permission:{{cookiecutter.pname}}"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<{{cookiecutter.pname}}Resource>(name);
        }
    }
}