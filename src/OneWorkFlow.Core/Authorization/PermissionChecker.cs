using Abp.Authorization;
using OneWorkFlow.Authorization.Roles;
using OneWorkFlow.Authorization.Users;

namespace OneWorkFlow.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
