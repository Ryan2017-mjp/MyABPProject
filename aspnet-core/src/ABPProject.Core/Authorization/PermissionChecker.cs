using Abp.Authorization;
using ABPProject.Authorization.Roles;
using ABPProject.Authorization.Users;

namespace ABPProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
