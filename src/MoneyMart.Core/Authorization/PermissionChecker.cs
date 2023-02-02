using Abp.Authorization;
using MoneyMart.Authorization.Roles;
using MoneyMart.Authorization.Users;

namespace MoneyMart.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
