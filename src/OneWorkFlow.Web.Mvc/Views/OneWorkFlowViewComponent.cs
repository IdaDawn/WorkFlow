using Abp.AspNetCore.Mvc.ViewComponents;

namespace OneWorkFlow.Web.Views
{
    public abstract class OneWorkFlowViewComponent : AbpViewComponent
    {
        protected OneWorkFlowViewComponent()
        {
            LocalizationSourceName = OneWorkFlowConsts.LocalizationSourceName;
        }
    }
}
