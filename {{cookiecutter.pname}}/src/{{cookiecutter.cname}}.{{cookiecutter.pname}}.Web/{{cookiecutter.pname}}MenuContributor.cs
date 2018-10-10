using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace {{cookiecutter.cname}}.{{cookiecutter.pname}}
{
    public class {{cookiecutter.pname}}MenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenu(context);
            }
        }

        private Task ConfigureMainMenu(MenuConfigurationContext context)
        {
            //Add main menu items.

            return Task.CompletedTask;
        }
    }
}