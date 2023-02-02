using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MoneyMart.Controllers
{
    public abstract class MoneyMartControllerBase: AbpController
    {
        protected MoneyMartControllerBase()
        {
            LocalizationSourceName = MoneyMartConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
