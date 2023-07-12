using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entites;

namespace Casgem_Portfolio.Controllers
{
  
    public class ServiceController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddService(Service p)
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
        public ActionResult ServiceUpdate(int id)
        {
            var values = db.Services.Find(id);

            return View(values);
        }

        [HttpPost]
        public ActionResult ServiceUpdate(Service p)
        {
            var values = db.Services.Find(p.IDServices);
            values.ServiceTitle = p.ServiceTitle;
            values.ServiceNumber = p.ServiceNumber;
            values.ServiceContent = p.ServiceContent;
            values.ServiceIcon = p.ServiceIcon;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}