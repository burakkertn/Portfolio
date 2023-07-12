using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entites;

namespace Casgem_Portfolio.Controllers
{
    public class MessageController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.Messages.ToList();
            return View(values);
        }
        public ActionResult MessageDelete(int id)
        {
            var values = db.Messages.Find(id);
            db.Messages.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult MessageDetails(int id)
        {
            var values = db.Messages.Find(id);
                        return View(values);
        }

        [HttpPost]
        public ActionResult MessageDetails(Message p)
        {
            var values = db.Messages.Find(p.IDMessage);
            values.NameSurname = p.NameSurname;
            values.SenderMail = p.SenderMail;
            values.MessageSubject = p.MessageSubject;
            values.Contect = p.Contect;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}