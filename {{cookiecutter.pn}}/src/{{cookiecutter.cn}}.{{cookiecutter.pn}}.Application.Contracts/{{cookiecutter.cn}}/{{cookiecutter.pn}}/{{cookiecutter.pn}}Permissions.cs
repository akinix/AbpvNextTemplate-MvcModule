namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}
{
    public class {{cookiecutter.pn}}Permissions
    {
        public const string GroupName = "{{cookiecutter.pn}}";

        public static string[] GetAll()
        {
            return new[]
            {
                GroupName
            };
        }
    }
}