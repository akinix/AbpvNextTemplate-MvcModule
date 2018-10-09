using System.Threading.Tasks;
using Volo.Abp.Modularity;
using Xunit;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}
{
    public abstract class MyEntityRepository_Tests<TStartupModule> : {{cookiecutter.project_name}}TestBase<TStartupModule>
        where TStartupModule : IAbpModule
    {
        [Fact]
        public async Task Test1()
        {

        }
    }
}
