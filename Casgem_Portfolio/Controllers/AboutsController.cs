using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entites;
using Casgem_Portfolio.Repo;

namespace Casgem_Portfolio.Controllers
{
    public class AboutsController : Controller
    {
        GenericRepository<About> repo = new GenericRepository<About>();
        [HttpGet]
        public ActionResult Index()
        {
            var x = repo.List();
            return View(x);
        }

        [HttpPost]
        public ActionResult Index(About p)
        {
            var t = repo.Find(x => x.IDAbouts == 1);
            t.Name = p.Name;
            t.Surname = p.Surname;
            t.Address = p.Address;
           t.Mail= p.Mail;
            t.PhoneNumber = p.PhoneNumber;
            t.Des = p.Des;
           
            t.ImageUrl = p.ImageUrl;
            repo.XUpdate(t);
            return RedirectToAction("Index");
        }
    }
}