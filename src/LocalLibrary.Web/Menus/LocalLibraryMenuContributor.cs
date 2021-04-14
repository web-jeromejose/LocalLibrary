using LocalLibrary.Localization;
using LocalLibrary.MultiTenancy;
using System.Threading.Tasks;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace LocalLibrary.Web.Menus
{
    public class LocalLibraryMenuContributor : IMenuContributor
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

            var l = context.GetLocalizer<LocalLibraryResource>();

           // context.Menu.Items.Insert(0, new ApplicationMenuItem(LocalLibraryMenus.Home, l["Menu:Home"], "~/"));

            //Add Menus
            context.Menu.AddItem(
                    new ApplicationMenuItem(
                        "BooksStore",
                        l["Menu:BookStore"],
                        icon: "fa fa-book"
                    ).AddItem(
                        new ApplicationMenuItem(
                            "BooksStore.Books",
                            l["Menu:Books"],
                            url: "/Books"
                        )
                    )
                );
        }
    }
}