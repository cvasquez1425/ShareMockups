using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ShareMockups.DataContexts;
using ShareMockups.DomainClasses;

namespace ShareMockups.Areas.SinglePageApps.Controllers
{
    public class TestController : Controller
    {
        private ShareMockupsContext db = new ShareMockupsContext();

        // GET: SinglePageApps/Test
        public ActionResult Index()
        {
            return View(db.ShareMockups.ToList());
        }

        // GET: SinglePageApps/Test/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShareMockup shareMockup = db.ShareMockups.Find(id);
            if (shareMockup == null)
            {
                return HttpNotFound();
            }
            return View(shareMockup);
        }

        // GET: SinglePageApps/Test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SinglePageApps/Test/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShareMockupId,MockupName,Url,Description,Rate,Available,UserDefined,UserDefined2,UserDefined3")] ShareMockup shareMockup)
        {
            if (ModelState.IsValid)
            {
                db.ShareMockups.Add(shareMockup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shareMockup);
        }

        // GET: SinglePageApps/Test/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShareMockup shareMockup = db.ShareMockups.Find(id);
            if (shareMockup == null)
            {
                return HttpNotFound();
            }
            return View(shareMockup);
        }

        // POST: SinglePageApps/Test/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShareMockupId,MockupName,Url,Description,Rate,Available,UserDefined,UserDefined2,UserDefined3")] ShareMockup shareMockup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shareMockup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shareMockup);
        }

        // GET: SinglePageApps/Test/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShareMockup shareMockup = db.ShareMockups.Find(id);
            if (shareMockup == null)
            {
                return HttpNotFound();
            }
            return View(shareMockup);
        }

        // POST: SinglePageApps/Test/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShareMockup shareMockup = db.ShareMockups.Find(id);
            db.ShareMockups.Remove(shareMockup);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
