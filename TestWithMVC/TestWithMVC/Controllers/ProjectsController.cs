using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWithMVC.Models;

namespace TestWithMVC.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/Projects/Create")]
        public ActionResult Create(Project project)
        {
            return this.Edit(project);
        }

        [HttpGet]
        [Route("/Projects/Edit")]
        public ActionResult Edit(Project project)
        {
            return this.View(model: project);
        }
    }
}