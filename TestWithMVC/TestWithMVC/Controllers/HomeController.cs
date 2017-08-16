using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWithMVC.Models;

namespace TestWithMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var project = new Project();
            return View(project);
        }

        [HttpPost]
        public ActionResult Index(Project project)
        {
            // Add project values
            //project.AddPart("Case", "ATX", "http://cdn.mos.cms.futurecdn.net/vs6rTReqdbang9Pcwy7YM9-320-80.png", 167.50);
            //project.AddPart("Case", "ITX", "http://cdn.mos.cms.futurecdn.net/vs6rTReqdbang9Pcwy7YM9-320-80.png", 103.20);

            return RedirectToAction("Edit", "Projects", project);
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
        public ActionResult getProjectName()
        {
            return null; //View(new Models.Project { projectName =  });
        }
    }
}