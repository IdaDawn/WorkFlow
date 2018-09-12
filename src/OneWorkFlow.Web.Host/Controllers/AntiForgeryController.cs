using Microsoft.AspNetCore.Antiforgery;
using OneWorkFlow.Controllers;

namespace OneWorkFlow.Web.Host.Controllers
{
    public class AntiForgeryController : OneWorkFlowControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
