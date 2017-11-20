using System.Web.Mvc;
using DomainServices;

namespace WireUp.Controllers
{
    public class HomeController : Controller
    {
        IService2000 service;

        public HomeController(IService2000 service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult About()
        {
            return Json(new { Value = service.Add2000(4) }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}