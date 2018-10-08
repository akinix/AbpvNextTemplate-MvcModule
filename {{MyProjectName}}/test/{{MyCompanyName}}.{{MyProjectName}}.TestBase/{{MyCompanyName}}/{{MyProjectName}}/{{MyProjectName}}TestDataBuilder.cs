using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;

namespace {{MyCompanyName}}.{{MyProjectName}}
{
    public class {{MyProjectName}}TestDataBuilder : ITransientDependency
    {
        private readonly IGuidGenerator _guidGenerator;
        private {{MyProjectName}}TestData _testData;

        public {{MyProjectName}}TestDataBuilder(
            IGuidGenerator guidGenerator,
            {{MyProjectName}}TestData testData)
        {
            _guidGenerator = guidGenerator;
            _testData = testData;
        }

        public void Build()
        {
            
        }
    }
}