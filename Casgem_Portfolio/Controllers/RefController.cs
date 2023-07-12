using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entites;

namespace Casgem_Portfolio.Controllers
{
    public class RefController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.Refs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddRef()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRef(Ref p)
        {
            db.Refs.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RefDelete(int id)
        {
            var values = db.Refs.Find(id);
            db.Refs.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult RefUpdate(int id)
        {
            var values = db.Refs.Find(id);

            return View(values);
        }

        [HttpPost]
        public ActionResult RefUpdate(Ref p)
        {
            var values = db.Refs.Find(p.IDRef);
            values.RefNameSurname = p.RefNameSurname;
            values.RefJob = p.RefJob;
            values.RefNumber = p.RefNumber;
            values.RefMail = p.RefMail;
            values.ImageUrl = p.ImageUrl;



            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}