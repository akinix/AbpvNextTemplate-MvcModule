namespace {{MyCompanyName}}.{{MyProjectName}}
{
    public class {{MyProjectName}}Permissions
    {
        public const string GroupName = "{{MyProjectName}}";

        public static string[] GetAll()
        {
            return new[]
            {
                GroupName
            };
        }
    }
}