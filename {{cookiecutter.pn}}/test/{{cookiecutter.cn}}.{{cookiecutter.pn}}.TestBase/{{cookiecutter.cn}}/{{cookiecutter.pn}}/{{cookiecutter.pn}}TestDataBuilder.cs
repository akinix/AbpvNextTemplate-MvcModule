using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}
{
    public class {{cookiecutter.pn}}TestDataBuilder : ITransientDependency
    {
        private readonly IGuidGenerator _guidGenerator;
        private {{cookiecutter.pn}}TestData _testData;

        public {{cookiecutter.pn}}TestDataBuilder(
            IGuidGenerator guidGenerator,
            {{cookiecutter.pn}}TestData testData)
        {
            _guidGenerator = guidGenerator;
            _testData = testData;
        }

        public void Build()
        {
            
        }
    }
}