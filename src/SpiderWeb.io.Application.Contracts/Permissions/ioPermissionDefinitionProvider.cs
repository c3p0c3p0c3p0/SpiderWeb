using SpiderWeb.io.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SpiderWeb.io.Permissions
{
    public class ioPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ioPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ioPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ioResource>(name);
        }
    }
}
