using ShareMockups.DomainClasses;
using System.Web.Mvc;

namespace SinglePageApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TrainingProductManager mgr = new TrainingProductManager();

            return View(mgr.Get());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}