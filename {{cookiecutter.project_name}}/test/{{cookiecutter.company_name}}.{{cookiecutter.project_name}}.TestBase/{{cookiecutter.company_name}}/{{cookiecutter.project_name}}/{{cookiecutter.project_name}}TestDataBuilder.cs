using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}
{
    public class {{cookiecutter.project_name}}TestDataBuilder : ITransientDependency
    {
        private readonly IGuidGenerator _guidGenerator;
        private {{cookiecutter.project_name}}TestData _testData;

        public {{cookiecutter.project_name}}TestDataBuilder(
            IGuidGenerator guidGenerator,
            {{cookiecutter.project_name}}TestData testData)
        {
            _guidGenerator = guidGenerator;
            _testData = testData;
        }

        public void Build()
        {
            
        }
    }
}