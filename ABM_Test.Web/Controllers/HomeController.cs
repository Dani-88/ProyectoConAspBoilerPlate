using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ABM_Test.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABM_TestControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}