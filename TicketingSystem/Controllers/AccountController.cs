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

        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
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

                if (string.IsNullOrEmpty(returnUrl))
                    return RedirectToAction("AllTickets", "Ticket");
                else
                    return Redirect(returnUrl);
            }
            else
            {
                ModelState.AddModelError("Username", "Incorrect credentials.");
                return View();
            }
        }

        public ActionResult ProfileInfo()
        {
            DB.User user = DB.User.Get(int.Parse(UserID));
            return View(user);
        }

        public ActionResult EditProfile(int id)
        {
            DB.User user = DB.User.Get(int.Parse(UserID));
            return View(user);
        }

        [HttpPost]
        public ActionResult EditProfile(User user)
        {
            user.Update(user.UserID);
            return RedirectToAction("ProfileInfo");
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
