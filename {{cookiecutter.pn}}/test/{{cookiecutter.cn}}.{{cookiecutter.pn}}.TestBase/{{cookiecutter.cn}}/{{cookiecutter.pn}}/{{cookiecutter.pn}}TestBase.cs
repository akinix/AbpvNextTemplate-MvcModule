using Volo.Abp;
using Volo.Abp.Modularity;

namespace {{cookiecutter.cn}}.{{cookiecutter.pn}}
{
    public abstract class {{cookiecutter.pn}}TestBase<TStartupModule> : AbpIntegratedTest<TStartupModule> 
        where TStartupModule : IAbpModule
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}
