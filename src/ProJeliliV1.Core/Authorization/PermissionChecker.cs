using Abp.Authorization;
using ProJeliliV1.Authorization.Roles;
using ProJeliliV1.Authorization.Users;

namespace ProJeliliV1.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
