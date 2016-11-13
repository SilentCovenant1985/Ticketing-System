using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Database;

namespace TicketingSystem.Database
{
    public class Category 
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

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string CetegoryDescription { get; set; }

        public static IEnumerable<Category> All()
        {
            string sql = string.Format("SELECT * FROM Categories");
            SqlDataReader reader = DBHelper.Query(sql);
            IEnumerable<Category> categories = MapReaderToCategory(reader);

            return categories;
        }

        public static Category Get(string categoryName)
        {
            string sql = string.Format("SELECT * FROM Categories WHERE CategoryName = '{1}'",categoryName);
            SqlDataReader reader = DBHelper.Query(sql);
            IEnumerable<Category> categories = MapReaderToCategory(reader);

            return categories.FirstOrDefault();
        }

        public static Category Get(int id)
        {
            string sql = string.Format("SELECT * FROM Categories WHERE CategoryID = {0}", id);
            SqlDataReader reader = DBHelper.Query(sql);
            IEnumerable<Category> categories = MapReaderToCategory(reader);

            return categories.FirstOrDefault();
        }

        private static IEnumerable<Category>MapReaderToCategory(SqlDataReader reader)
        {
            List<Category> retval = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category();
                category.CategoryID = int.Parse(reader["CategoryID"].ToString());
                category.CategoryName = reader["CategoryName"].ToString();
                category.CetegoryDescription = reader["CategoryDescription"].ToString();
                retval.Add(category);
            }

            return retval;
        }
    }
}
