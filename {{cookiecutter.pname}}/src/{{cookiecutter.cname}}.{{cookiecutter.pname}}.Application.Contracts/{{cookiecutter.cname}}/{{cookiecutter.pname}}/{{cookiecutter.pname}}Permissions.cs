namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}
{
    public class {{cookiecutter.pname}}Permissions
    {
        public const string GroupName = "{{cookiecutter.pname}}";

        public static string[] GetAll()
        {
            return new[]
            {
                GroupName
            };
        }
    }
}