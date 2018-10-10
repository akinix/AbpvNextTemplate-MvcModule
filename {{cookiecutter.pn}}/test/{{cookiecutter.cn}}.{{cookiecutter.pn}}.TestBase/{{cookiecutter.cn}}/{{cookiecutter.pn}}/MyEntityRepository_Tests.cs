using System.Threading.Tasks;
using Volo.Abp.Modularity;
using Xunit;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}
{
    public abstract class MyEntityRepository_Tests<TStartupModule> : {{cookiecutter.pn}}TestBase<TStartupModule>
        where TStartupModule : IAbpModule
    {
        [Fact]
        public async Task Test1()
        {

        }
    }
}
