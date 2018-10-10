using Volo.Abp.Threading;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}.MongoDB
{
    public static class {{cookiecutter.pn}}BsonClassMap
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