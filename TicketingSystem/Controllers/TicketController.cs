using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TicketingSystem.Database;
using DB = TicketingSystem.Database;

namespace TicketingSystem.Controllers
{
    public class TicketController : BaseController
    {
        [HttpGet]
        public ActionResult CreateTicket()
        {
            if (LoginUser == "GUEST")
            {
                return RedirectToAction("Login", "Account", new { returnUrl = Request.Url.AbsolutePath });
            }

            return View();
        }
        
        [HttpPost]
        public ActionResult CreateTicket(Request request)
        {
            request.TrackingNumber = Guid.NewGuid().ToString();
            request.CategoryID = int.Parse(request.TicketCategory);
            request.UserID = int.Parse(UserID);
            request.Save();

            return RedirectToAction("Index", "Home");       
        }

        [HttpPost]
        public ActionResult EditTicket(int id)
        {
            DB.Request request = DB.Request.Get(id);
            return View(request);
        }

        public ActionResult FindTicket(string trackingNumber)
        {
            return null;
        }

        public ActionResult AllTickets()
        {
            IEnumerable<DB.Request> requests = DB.Request.GetTicketsByUser(int.Parse(UserID));
            return View(requests);
        }
    
    }
}
