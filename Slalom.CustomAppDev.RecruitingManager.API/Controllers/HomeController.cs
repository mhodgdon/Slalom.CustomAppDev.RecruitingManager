using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Slalom.CustomAppDev.RecruitingManager.API.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Provides home view with a list of Operations
        /// </summary>
        public ActionResult Index()
        {
            return View();
        }
    }
}
