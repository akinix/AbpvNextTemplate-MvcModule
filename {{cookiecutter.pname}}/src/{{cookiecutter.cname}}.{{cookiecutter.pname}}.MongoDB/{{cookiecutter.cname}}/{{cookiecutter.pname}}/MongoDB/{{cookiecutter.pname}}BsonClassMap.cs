using Volo.Abp.Threading;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}.MongoDB
{
    public static class {{cookiecutter.pname}}BsonClassMap
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