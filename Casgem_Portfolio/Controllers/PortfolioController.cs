using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entites;


namespace Casgem_Portfolio.Controllers
{
    public class PortfolioController : Controller
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
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterScript()
        {
            return PartialView();
        }
        public PartialViewResult TestMonialPartial()
        {
            var values = db.Refs.ToList();
            return PartialView(values);
        }
        public PartialViewResult FeaturePartial()
        {
            ViewBag.featureTitle = db.Features.Select(x => x.FeatureTitle).FirstOrDefault();
            ViewBag.featureDescription = db.Features.Select(x => x.FeatureDes).FirstOrDefault();
            ViewBag.featureImage = db.Features.Select(x => x.FeatureImageUrl).FirstOrDefault();



            return PartialView();
            
        }

        public PartialViewResult MyResume()
        {
            var values = db.Resumes.ToList();
            return PartialView(values);
        }

        public PartialViewResult StatisticPartial()
        {
            ViewBag.totalService = db.Services.Count();
            ViewBag.totalMessage = db.Messages.Count();
            ViewBag.totalThanksMessage = db.Messages.Where(x => x.MessageSubject == "Teşekkür").Count();
            ViewBag.happyCustomer = 12;
            return PartialView();
        }
        public PartialViewResult WhoamiPartial()
        {

            var values = db.Abouts.ToList();
            return PartialView(values);
        }
        public PartialViewResult VideoPartial()
        {
            var values = db.Videos.ToList();
            return PartialView(values);
        }
        public PartialViewResult FreelancePartial()
        {
            return PartialView();
        }
        public PartialViewResult ServicesPartial()
        {

            var values = db.Services.ToList();
            return PartialView(values);
        }

    }
}