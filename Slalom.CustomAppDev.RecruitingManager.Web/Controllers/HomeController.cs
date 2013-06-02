using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Slalom.CustomAppDev.RecruitingManager.DomainObjects.Competency;
using Slalom.CustomAppDev.RecruitingManager.Commons.DataHelpers;
using Slalom.CustomAppDev.RecruitingManager.Web.Models;

namespace Slalom.CustomAppDev.RecruitingManager.Web.Controllers
{   
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeModel model = new HomeModel()
            {
                CompetencyAreas = CompetencyAreaHelper.GetAreas()
            };
            
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
