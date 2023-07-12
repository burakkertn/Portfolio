using Casgem_Portfolio.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Casgem_Portfolio.Controllers
{
    [AllowAnonymous]
    public class AdminController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin p)
        {
            CasgemPortfolioEntities db = new CasgemPortfolioEntities();
            var user = db.Admins.FirstOrDefault(x => x.Admina == p.Admina && x.Sifre == p.Sifre);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.Admina, false);
                Session["Admina"] = user.Admina.ToString();
                return RedirectToAction("Index", "Abouts");
            }
            else
            {
                return RedirectToAction("Index", "Admin");
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Admin");
        }
    }
}