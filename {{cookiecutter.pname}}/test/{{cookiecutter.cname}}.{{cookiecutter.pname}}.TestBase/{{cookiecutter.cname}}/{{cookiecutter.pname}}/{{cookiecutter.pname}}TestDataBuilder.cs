using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}
{
    public class {{cookiecutter.pname}}TestDataBuilder : ITransientDependency
    {
        private readonly IGuidGenerator _guidGenerator;
        private {{cookiecutter.pname}}TestData _testData;

        public {{cookiecutter.pname}}TestDataBuilder(
            IGuidGenerator guidGenerator,
            {{cookiecutter.pname}}TestData testData)
        {
            _guidGenerator = guidGenerator;
            _testData = testData;
        }

        public void Build()
        {
            
        }
    }
}