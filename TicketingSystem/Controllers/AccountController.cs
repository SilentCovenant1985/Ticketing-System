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
    public class AccountController : BaseController
    {
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            user.Save();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Login(string returnUrl)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login login, string returnUrl)
        {
            Database.User user = Database.User.Get(login.UserName, login.Password);
            login.Valid = user != null;

            if (login.Valid)
            {
                LoginUser = user.Name;
                UserID = user.UserID.ToString();

                if (string.IsNullOrEmpty(returnUrl) == false)
                    RedirectToLocal(returnUrl);
            }
            else
            {
                ModelState.AddModelError("Username", "Incorrect credentials.");
            }

            return View();
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult LogOff()
        {
            LoginUser = "GUEST";
            return RedirectToAction("Index", "Home");
;        }

        public User FindUser(int id)
        {
            User user = DB.User.Get(id);
            return user;
        }

        public void DeleteUser(int id)
        {
            DB.User user = FindUser(id);
            if (user == null)
                return;

            user.Delete(id);
        }
    }
}
