using Casgem_Portfolio.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace Casgem_Portfolio.Controllers
{
    public class ContactController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Message p)
        {
            db.Messages.Add(p); 
            db.SaveChanges();
            return RedirectToAction("HeaderPartial", "Portfolio");
        }
    }
}