using Volo.Abp.Threading;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.MongoDB
{
    public static class {{cookiecutter.project_name}}BsonClassMap
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            OneTimeRunner.Run(() =>
            {
                //Register mappings here. Example:
                //BsonClassMap.RegisterClassMap<Question>(map =>
                //{
                //    map.AutoMap();
                //});
            });
        }
    }
}