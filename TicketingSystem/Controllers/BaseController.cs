using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using TicketingSystem.Database;
using DB = TicketingSystem.Database;

namespace TicketingSystem.Controllers
{
    public class BaseController : Controller
    {
        protected string LoginUser
        {
            get
            {
                return (string)Session["USER"]; 
            }
            set
            {
                string newValue = value ?? "";
                string user = Session["USER"] as string;

                if (user == null)
                    Session.Add("USER", newValue);
                else
                    Session["USER"] = newValue;
            }

        }

        protected string UserID
        {
            get
            {
                return (string)Session["ID"];
            }
            set
            {
                string newValue = value ?? "";
                string user = Session["ID"] as string;

                if (user == null)
                    Session.Add("ID", newValue);
                else
                    Session["ID"] = newValue;
            }

        }
    }
}
