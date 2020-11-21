using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using SpiderWeb.io.Localization;
using SpiderWeb.io.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace SpiderWeb.io.Web.Menus
{
    public class ioMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<ioResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(ioMenus.Home, l["Menu:Home"], "~/"));

            context.Menu.AddItem(
    new ApplicationMenuItem(
        "SpiderWeb",
        l["Menu:SpiderWeb"],
        icon: "fa fa-spider"
    ).AddItem(
        new ApplicationMenuItem(
            "SpiderWeb.io.Sources",
            l["Sources"],
            url: "/Sources"
        )
    )
);
        }
    }
}
