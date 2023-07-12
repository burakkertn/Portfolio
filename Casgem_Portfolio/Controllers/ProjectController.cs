using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entites;

namespace Casgem_Portfolio.Controllers
{
    public class ProjectController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.Projects.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProject(Project p)
        {
            db.Projects.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ProjectDelete(int id)
        {
            var values = db.Projects.Find(id);
            db.Projects.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ProjectUpdate(int id)
        {
            var values = db.Projects.Find(id);

            return View(values);
        }

        [HttpPost]
        public ActionResult ProjectUpdate(Project p)
        {
            var values = db.Projects.Find(p.IDProject);
            values.ProjectName = p.ProjectName;
            values.ProjectDes = p.ProjectDes;
     
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}