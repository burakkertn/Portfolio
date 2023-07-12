using Casgem_Portfolio.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class HizmetlerimController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();

        public ActionResult Index()
        {
            var values = db.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddHizmet()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddHizmet(Service p)
        {
            db.Services.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteService(int id)
        {
            var values = db.Services.Find(id);
            db.Services.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ServicesUpdate(int id)
        {
            var values = db.Services.Find(id);

            return View(values);
        }

        [HttpPost]
        public ActionResult ServicesUpdate(Service p)
        {
            var values = db.Services.Find(p.IDServices);
            values.ServiceTitle = p.ServiceTitle;
            values.ServiceIcon = p.ServiceIcon;
            values.ServiceNumber = p.ServiceNumber;
            values.ServiceContent = p.ServiceContent;

            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}