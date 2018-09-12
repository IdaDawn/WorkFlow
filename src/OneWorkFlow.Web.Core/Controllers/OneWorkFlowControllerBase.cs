using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace OneWorkFlow.Controllers
{
    public abstract class OneWorkFlowControllerBase: AbpController
    {
        protected OneWorkFlowControllerBase()
        {
            LocalizationSourceName = OneWorkFlowConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
