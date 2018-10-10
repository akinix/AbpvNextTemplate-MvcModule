using System.Threading.Tasks;
using Volo.Abp.Modularity;
using Xunit;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}
{
    public abstract class MyEntityRepository_Tests<TStartupModule> : {{cookiecutter.pname}}TestBase<TStartupModule>
        where TStartupModule : IAbpModule
    {
        [Fact]
        public async Task Test1()
        {

        }
    }
}
