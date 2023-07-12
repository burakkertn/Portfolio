using Casgem_Portfolio.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class UIAboutsController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();

        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult BreadcrumbPartial()
        {
            return PartialView();
        }

        public PartialViewResult AboutPartial()
        {
            var values = db.SocialMedias.ToList();
           

            ViewBag.Name = db.Abouts.Select(x => x.Name).FirstOrDefault();
            ViewBag.Surname = db.Abouts.Select(x => x.Surname).FirstOrDefault();
            ViewBag.Address = db.Abouts.Select(x => x.Address).FirstOrDefault();
            ViewBag.Des = db.Abouts.Select(x => x.Des).FirstOrDefault();
            ViewBag.PhoneNumber = db.Abouts.Select(x => x.PhoneNumber).FirstOrDefault();
            ViewBag.ImageUrl = db.Abouts.Select(x => x.ImageUrl).FirstOrDefault();
            ViewBag.Mail = db.Abouts.Select(x => x.Mail).FirstOrDefault();

            return PartialView(values);
        }
        public PartialViewResult About2Partial()
        {
            return PartialView();
        }
        public PartialViewResult About3Partial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterScript()
        {
            var values = db.SocialMedias.ToList();
            return PartialView(values);
        }
        public PartialViewResult AchievementsScript()
        {
            var values = db.Projects.ToList();
            return PartialView(values);
        }
        public PartialViewResult SubscribeScript()
        {

           
            return PartialView();
        }
    }
}
