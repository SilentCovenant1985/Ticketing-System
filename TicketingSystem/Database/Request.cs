using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TicketingSystem.Database
{
    public class Request
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

        public int RequestID { get; set; }

        public string TrackingNumber { get; set; }

        public string InitialDescription { get; set; }

        public string RequestStatus { get; set; }

        public DateTime DateSubmitted { get; set; }

        public string AttachmentFileName { get; set; }

        public string TicketCategory { get; set; }

        public int CategoryID { get; set; }

        public string CategoryName
        {
           get
            {
                var category = Category.Get(CategoryID);
                return category.CategoryName;
            }
        }

        public int UserID { get; set; }

        public string Requester
        {
            get
            {
                var user = User.Get(UserID);
                return user.Name;
            }
        }

        public IEnumerable<string> CategoryList
        {
            get
            {
                IEnumerable<string> list = Category.All().Select<Category, string>(item => item.CategoryName);
                return list;
            }
        }

        public static IEnumerable<SelectListItem> CategoryListForView
        {
            get
            {
                IEnumerable<SelectListItem> list = Category.All().Select<Category, SelectListItem>(item => new SelectListItem() { Text = item.CategoryName, Value = item.CategoryID.ToString()});
                return list;
            }
        }

        public void Save()
        {
            string sql = "INSERT INTO [dbo].[Requests]([TrackingNumber],[InitialDescription],[RequestStatus],[DateSubmitted],[AttachmentFileName],[Users_UserID],[Categories_CategoryID])" +
                         string.Format("VALUES('{0}','{1}','{2}','{3}','{4}',{5},{6})", TrackingNumber, InitialDescription, RequestStatus, DateSubmitted, AttachmentFileName, UserID, CategoryID);

            DBHelper.Execute(sql);
        }

        public void Update(int id)
        {
            string sql = string.Format("UPDATE [dbo].[Requests] {0}", 
            string.Format("SET [TrackingNumber]='{0}',[InitialDescription]='{1}',[RequestStatus]='{2}',[DateSubmitted]='{3}',[AttachmentFileName]='{4}' WHERE RequestId = {5}", 
                           TrackingNumber, InitialDescription, RequestStatus, DateSubmitted, AttachmentFileName,id));

            DBHelper.Execute(sql);
        }

        public static IEnumerable<Request> GetTicketsByUser(int userId)
        {
            string sql = string.Format("SELECT * FROM Requests WHERE Users_UserID = {0}", userId);
            SqlDataReader reader = DBHelper.Query(sql);
            IEnumerable<Request> requests = MapReaderToRequest(reader);

            return requests;
        }

        public static Request Get(int requestId)
        {
            string sql = string.Format("SELECT * FROM Requests WHERE RequestID = {0}", requestId);
            SqlDataReader reader = DBHelper.Query(sql);
            IEnumerable<Request> requests = MapReaderToRequest(reader);

            return requests.FirstOrDefault();
        }

        private static IEnumerable<Request> MapReaderToRequest(SqlDataReader reader)
        {
            List<Request> retval = new List<Request>();

            while (reader.Read())
            {
                Request request = new Request();
                request.RequestID = int.Parse(reader["RequestID"].ToString());
                request.TrackingNumber = reader["TrackingNumber"].ToString();
                request.InitialDescription = reader["InitialDescription"].ToString();
                request.RequestStatus = reader["RequestStatus"].ToString();
                request.DateSubmitted = DateTime.Parse(reader["DateSubmitted"].ToString());
                request.CategoryID = int.Parse(reader["Categories_CategoryID"].ToString());
                request.UserID = int.Parse(reader["Users_UserID"].ToString());
                retval.Add(request);
            }

            return retval;
        }
    }
}
