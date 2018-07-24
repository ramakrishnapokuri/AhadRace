using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AheadRace.Models;
namespace AheadRace.Controllers
{
    /// <summary>
    /// Controller for Home View
    /// </summary>
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Post Method of Indexpage 
        /// </summary>
        /// <param name="date">Date sent from view</param>
        /// <returns>Date diffrence in Days</returns>
        [HttpPost]
        public ActionResult Index(Date date)
        {
            if (ModelState.IsValid)
            {
                long diff = date.GetDateDiffrenceInDays();

                ViewBag.Message = diff;

                return View();
            }
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
    }
}