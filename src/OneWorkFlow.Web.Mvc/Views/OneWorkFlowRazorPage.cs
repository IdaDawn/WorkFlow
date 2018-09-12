using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace OneWorkFlow.Web.Views
{
    public abstract class OneWorkFlowRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected OneWorkFlowRazorPage()
        {
            LocalizationSourceName = OneWorkFlowConsts.LocalizationSourceName;
        }
    }
}
