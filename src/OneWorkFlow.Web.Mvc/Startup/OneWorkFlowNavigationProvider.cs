using Abp.Application.Navigation;
using Abp.Localization;
using OneWorkFlow.Authorization;

namespace OneWorkFlow.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class OneWorkFlowNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "home",
                        requiresAuthentication: true
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Tenants,
                        L("Tenants"),
                        url: "Tenants",
                        icon: "business",
                        requiredPermissionName: PermissionNames.Pages_Tenants
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Users,
                        L("Users"),
                        url: "Users",
                        icon: "people",
                        requiredPermissionName: PermissionNames.Pages_Users
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Roles,
                        L("Roles"),
                        url: "Roles",
                        icon: "local_offer",
                        requiredPermissionName: PermissionNames.Pages_Roles
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Component,
                        L("Components"),
                        url: "Components",
                        icon: "people"
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, OneWorkFlowConsts.LocalizationSourceName);
        }
    }
}
