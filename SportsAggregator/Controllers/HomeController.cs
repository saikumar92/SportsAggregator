using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsAggregator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            try
            {
                Session["UserName"] = null;
                return View();
            }
            catch(Exception)
            {
                return RedirectToAction("Error", "Error");
            }
        }

        public ActionResult About()
        {
            try
            {
                return View();
            }
            catch(Exception)
            {
                return RedirectToAction("Error", "Error");
            }
        }

        public ActionResult Contact()
        {
            try
            {
                return View();
            }
            catch(Exception)
            {
                return RedirectToAction("Error", "Error");
            }
        }
    }
}