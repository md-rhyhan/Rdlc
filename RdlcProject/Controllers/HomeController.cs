using Microsoft.Reporting.WebForms;
using RdlcProject.Database;
using RdlcProject.RdlcConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RdlcProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmpDbContext _empDbContext;
        public HomeController(EmpDbContext empDbContext)
        {
            _empDbContext = empDbContext;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CountryReport()
        {
            //var report = new LocalReport() { ReportPath=Server.MapPath("~/Reports/Report1.rdlc") };
            //report.Render("pdf",)

            var reportDataSource = new List<ReportDataSource>() { new ReportDataSource("DSCountry", _empDbContext.Countries.ToList()) };

            var config = new ReportConfig { ReportFilePath = Server.MapPath("~/Reports/Country.rdlc") };
            return new ReportResult(config, reportDataSource);
        }

        public ActionResult StateReport()
        {
            //var report = new LocalReport() { ReportPath=Server.MapPath("~/Reports/Report1.rdlc") };
            //report.Render("pdf",)
            var stateViews = (
       from s in _empDbContext.States
       join c in _empDbContext.Countries on s.CountryId equals c.Id
       select new
       {
           StateId = s.Id,
           StateName = s.Name,
           CountryId = c.Id,
           CountryName = c.Name
       }
   ).ToList();





            var reportDataSource = new List<ReportDataSource>() { new ReportDataSource("DsState", stateViews) };

            var config = new ReportConfig { ReportFilePath = Server.MapPath("~/Reports/Report1.rdlc") };
            return new ReportResult(config, reportDataSource);
        }
    }
}