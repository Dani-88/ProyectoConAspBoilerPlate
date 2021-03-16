using Abp.Authorization;
using ABM_Test.Authorization.Roles;
using ABM_Test.Authorization.Users;

namespace ABM_Test.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
