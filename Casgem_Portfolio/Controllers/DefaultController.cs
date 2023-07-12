using Casgem_Portfolio.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
 

    public class DefaultController : Controller
    {
    CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        public ActionResult Index()
        {
            var degerler = db.Abouts.ToList();
            return View(degerler);
        }

        public ActionResult PersonList()
        {
            return View();
        }
        public ActionResult DepertmentList()
        {
            return View();
        }
    }
}