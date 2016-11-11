using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TicketingSystem.Database;
using TSUser = TicketingSystem.Database;

namespace TicketingSystem.Controllers
{
    public class UserController : Controller
    {
        public void AddUser(string userName, string password, string name, string email, string phone, string company, string usertype)
        {
            User user = new User();
            user.Username = userName;
            user.Password = password;
            user.Name = name;
            user.Email = email;
            user.Phone = phone;
            user.Company = company;
            user.UserType = usertype;
            user.Save();
        }

        public User FindUser(int id)
        {
            TSUser.User user = TSUser.User.Get(id);
            return user;
        }

        public void UpdateUser(int id, string userName, string password, string name, string email, string phone, string company, string usertype)
        {
            TSUser.User user = FindUser(id);
            if (user == null)
                return;

            user.Username = userName;
            user.Password = password;
            user.Name = name;
            user.Email = email;
            user.Phone = phone;
            user.Company = company;
            user.UserType = usertype;
            user.Update();
        }

        public void DeleteUser(int id)
        {
            TSUser.User user = FindUser(id);
            if (user == null)
                return;

            user.Delete(id);
        }
    }
}
