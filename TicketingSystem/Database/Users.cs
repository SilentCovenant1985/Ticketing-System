using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Database
{
    public class User
    {
        private static DatabaseHelper _dbHelper;
        public static DatabaseHelper DBHelper
        {
            get
            {

                if (_dbHelper == null)             
                    _dbHelper = new DatabaseHelper();

                return _dbHelper;
            }
        }

        public int UserID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string  Email { get; set; }

        public string Phone { get; set; }

        public string Company { get; set; }

        public string UserType { get; set; }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(Username))
                return false;

            if (string.IsNullOrEmpty(Name))
                return false;

            return true;
        }

        public void Save()
        {
            if (!IsValid())
                return;

            string sql = "INSERT INTO [dbo].[Users]([Username],[Password],[Name],[Email],[Phone],[Company],[UserType])" +
                         string.Format("VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", Username, Password, Name, Email, Phone, Company, UserType);

            DBHelper.Execute(sql);
        }

        public void Update()
        {
            string sql = string.Format("UPDATE [dbo].[Users] SET [UserID] = {0}, [Username] = {1},[Password] = {2},[Name] = {3},[Email] = {4},[Phone] = {5},[Company] = {6}, [UserType] = {7}",
                                        Username, Password, Name, Email, Phone, Company, UserType);

            DBHelper.Execute(sql);
        }

        public void Delete(int id)
        {
            string sql = string.Format("DELETE FROM [dbo].[Users] WHERE ID = {0}", id);

            DBHelper.Execute(sql);
        }

        public static User Get(int id)
        {
            string sql = string.Format("select * from Users where UserID = {0}", id);
            SqlDataReader reader = DBHelper.Query(sql);
            User user = MapReaderToUser(reader);

            return user;
        }

        public static User Get(string username)
        {
            string sql = string.Format("SELECT * FROM Users WHERE Username = '{0}'", username);
            SqlDataReader reader = DBHelper.Query(sql);
            User user = MapReaderToUser(reader);

            return user;
        }

        public static User Get(string username, string password)
        {
            string sql = string.Format("SELECT * FROM Users WHERE Username = '{0}' AND Password = '{1}'", username,password);
            SqlDataReader reader = DBHelper.Query(sql);
            User user = MapReaderToUser(reader);

            return user;
        }

        private static User MapReaderToUser(SqlDataReader reader)
        {
            if (reader.Read() == false)
                return null;

            User user = new User();
            user.UserID = int.Parse(reader["UserId"].ToString());
            user.Username = reader["Username"].ToString();
            user.Password = reader["Password"].ToString();
            user.Name = reader["Name"].ToString();
            user.Email = reader["Email"].ToString();
            user.Phone = reader["Phone"].ToString();
            user.Company = reader["Company"].ToString();
            user.UserType = reader["UserType"].ToString();

            return user;
        } 
    }
}
