using ShareMockups.DataContexts;
using ShareMockups.DomainClasses;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ShareMockups.Controllers
{
    public class HomeController : Controller
    {
        private ShareMockupsContext db = new ShareMockupsContext();

        public ActionResult Index()
        {
            ShareMockupsViewModel vm = new ShareMockupsViewModel();

            vm.HandleRequest();

            return View(vm);     //.Mockups.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "This Page will be available soon.";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "This Page is Still Under Construction.";

            return View();
        }

        //[Authorize]
        public ActionResult IndexMockup()
        {

            return View(db.ShareMockups.ToList());

        }

        public ActionResult Create()
        {
            return View();
        }

        //POST: /Home/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize]
        public ActionResult Create([Bind(Include= "ShareMockupId,MockupName,Url,Description,Rate,Available")] ShareMockup sharemockup)
        {
            if (ModelState.IsValid)
            {
                db.ShareMockups.Add(sharemockup);
                db.SaveChanges();
                return RedirectToAction("IndexMockup");
            }

            return View(sharemockup);
        }

        //[Authorize]
        //GET: /Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ShareMockup sharemockup = db.ShareMockups.Find(id);
            if (sharemockup == null)
            {
                return HttpNotFound();
            }

            return View(sharemockup);
        }

        //GET: /Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ShareMockup sharemockup = db.ShareMockups.Find(id);
            if (sharemockup == null)
            {
                return HttpNotFound();
            }

            return View(sharemockup);

        }

    }
}