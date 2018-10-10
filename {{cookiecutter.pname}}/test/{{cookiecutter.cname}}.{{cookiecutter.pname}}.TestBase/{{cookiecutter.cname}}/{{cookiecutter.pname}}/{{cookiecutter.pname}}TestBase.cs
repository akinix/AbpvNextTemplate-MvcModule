using Volo.Abp;
using Volo.Abp.Modularity;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}
{
    public abstract class {{cookiecutter.pname}}TestBase<TStartupModule> : AbpIntegratedTest<TStartupModule> 
        where TStartupModule : IAbpModule
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}
