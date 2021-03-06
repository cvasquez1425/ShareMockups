﻿using ShareMockups.DataContexts;
using ShareMockups.DomainClasses;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ShareMockups.Controllers
{
    public class HomeController : Controller
    {
        private static ShareMockupsContext ctx = new ShareMockupsContext();

        public ActionResult Index()
        {
            ShareMockupsViewModel vm = new ShareMockupsViewModel();

            vm.HandleRequest();

            ViewData["Foo"] = "Home Page";  //  Allows you to store data in a controller action that will be used in the corresponding view. 
                                            //  This assumes that the action returns a view and doesn't redirect. Lives only during the current request.

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

            return View(ctx.ShareMockups.ToList());

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
                ctx.ShareMockups.Add(sharemockup);
                ctx.SaveChanges();
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

            ShareMockup sharemockup = ctx.ShareMockups.Find(id);

            if (sharemockup == null)
            {
                return HttpNotFound();
            }

            return View(sharemockup);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind(Include = "ShareMockupId,MockupName,Url,Description,Rate,Available")] ShareMockup sharemockup)
        {
           var model = ctx.ShareMockups.Single(s => s.ShareMockupId == id);

            if (TryUpdateModel(model))
            {
                ctx.Database.Log = sql => Debug.Write(sql);

                var attachedEntry = ctx.Entry(model);
                attachedEntry.CurrentValues.SetValues(model);

                ctx.SaveChanges();
                return RedirectToAction("IndexMockup");
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

            ShareMockup sharemockup = ctx.ShareMockups.Find(id);
            if (sharemockup == null)
            {
                return HttpNotFound();
            }

            return View(sharemockup);

        }

        //GET: /Home/Delete/5
        public ActionResult ShareMockupsDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ShareMockup sharemockup = ctx.ShareMockups.Find(id);
            if (sharemockup == null)
            {
                return HttpNotFound();
            }
            return View(sharemockup);

        }

        //POST: ShareMockups/Confirm Delete
        [HttpPost, ActionName("ShareMockupsDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult ShareMockupsDeleteConfirm(int? id)
        {
            ctx.Database.Log = sql => Debug.Write(sql);

            ShareMockup sharemockup = ctx.ShareMockups.Find(id);
            ctx.ShareMockups.Remove(sharemockup);
            ctx.SaveChanges();
            return RedirectToAction("IndexMockup");
        }

    }
}