namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}
{
    public class {{cookiecutter.project_name}}Permissions
    {
        public const string GroupName = "{{cookiecutter.project_name}}";

        public static string[] GetAll()
        {
            return new[]
            {
                GroupName
            };
        }
    }
}