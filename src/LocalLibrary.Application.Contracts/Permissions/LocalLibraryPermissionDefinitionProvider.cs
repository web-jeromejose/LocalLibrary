using LocalLibrary.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LocalLibrary.Permissions
{
    public class LocalLibraryPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(LocalLibraryPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(LocalLibraryPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<LocalLibraryResource>(name);
        }
    }
}
