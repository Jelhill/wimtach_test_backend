using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ProJeliliV1.Controllers
{
    public abstract class ProJeliliV1ControllerBase: AbpController
    {
        protected ProJeliliV1ControllerBase()
        {
            LocalizationSourceName = ProJeliliV1Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
