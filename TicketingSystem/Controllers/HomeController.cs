using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketingSystem.Database;

namespace TicketingSystem.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            if (LoginUser == "GUEST")
                return View();
            else
                return RedirectToAction("AllTickets", "Ticket");
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