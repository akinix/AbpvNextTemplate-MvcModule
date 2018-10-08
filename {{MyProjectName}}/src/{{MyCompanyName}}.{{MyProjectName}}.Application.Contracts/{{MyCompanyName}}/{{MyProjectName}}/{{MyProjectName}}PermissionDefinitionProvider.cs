using {{MyCompanyName}}.{{MyProjectName}}.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace {{MyCompanyName}}.{{MyProjectName}}
{
    public class {{MyProjectName}}PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup({{MyProjectName}}Permissions.GroupName, L("Permission:{{MyProjectName}}"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<{{MyProjectName}}Resource>(name);
        }
    }
}