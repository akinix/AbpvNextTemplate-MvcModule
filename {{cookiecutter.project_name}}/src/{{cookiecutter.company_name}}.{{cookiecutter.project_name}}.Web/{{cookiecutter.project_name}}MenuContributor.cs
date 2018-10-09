using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}
{
    public class {{cookiecutter.project_name}}MenuContributor : IMenuContributor
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