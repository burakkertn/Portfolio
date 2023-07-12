using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entites;

namespace Casgem_Portfolio.Controllers
{
    public class StatisticController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        public ActionResult Index()
        {
            ViewBag.employeeCount = db.Empolees.Count();

            var salary = db.Empolees.Max(x => x.Salary);
            ViewBag.maxSalaryEmployee = db.Empolees.Where(x => x.Salary == salary).Select(
                y => y.Name + " " + y.SurName).FirstOrDefault();


            ViewBag.totalCityCount = db.Empolees.Select(x => x.City).Distinct().Count();

            ViewBag.avgEmployeeSalary = db.Empolees.Average(x => x.Salary);

            ViewBag.countSoftwareDepartment = db.Empolees.Where(
                x => x.Depertmant == db.TDepertmants.Where(
                    z => z.Name == "Yazılım").Select(y => y.ID).FirstOrDefault()).Count();

            ViewBag.cityAdanaOrAnkaraTotalSalary = db.Empolees.Where(
                x => x.City == "Ankara" || x.City == "Adana").Sum(y => y.Salary);

            ViewBag.sumSalaryFromSoftwareDepartment = db.Empolees.Where(
                x => x.City == "Ankara" && x.Depertmant == db.TDepertmants.Where(
                    z => z.Name == "Yazılım").Select(
                    y => y.ID).FirstOrDefault()).Sum(y => y.Salary);

            return View();
        }
    }
}