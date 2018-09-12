using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using OneWorkFlow.Controllers;

namespace OneWorkFlow.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : OneWorkFlowControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
