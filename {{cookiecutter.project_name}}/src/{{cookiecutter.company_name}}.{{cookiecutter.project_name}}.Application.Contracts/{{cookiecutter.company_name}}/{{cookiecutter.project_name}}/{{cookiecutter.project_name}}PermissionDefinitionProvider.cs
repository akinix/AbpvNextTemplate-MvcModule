using {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}
{
    public class {{cookiecutter.project_name}}PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup({{cookiecutter.project_name}}Permissions.GroupName, L("Permission:{{cookiecutter.project_name}}"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<{{cookiecutter.project_name}}Resource>(name);
        }
    }
}