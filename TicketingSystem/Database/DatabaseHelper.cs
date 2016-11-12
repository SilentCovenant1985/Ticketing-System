using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TicketingSystem.Database
{
    public class DatabaseHelper : IDisposable
    {
        private string _connectionString;
        public string ConnectionString
        {
            get
            {
                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }

        private SqlConnection _connection;
        public SqlConnection Connection
        {
            get
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                return _connection;
            }             
        }

        public DatabaseHelper()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;             
        }
        public DatabaseHelper(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public DatabaseHelper(string server, string databaseName)
        {
            ConnectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=SSPI",server,databaseName);
        }
        public DatabaseHelper(string server, string databaseName, string userName, string password)
        {
            ConnectionString = string.Format("Data Source={0};Initial Catalog={1};userid = {2}; password={3}", server, databaseName, userName, password);
        }

        public bool Execute(string sql)
        {
            SqlCommand  command = Connection.CreateCommand();
            command.CommandText = sql;
            var result = command.ExecuteNonQuery();

            return result >= 0;
        }

        public SqlDataReader Query(string sql)
        {
            SqlCommand command = Connection.CreateCommand();
            command.CommandText = sql;
            return command.ExecuteReader();
        }

        public void Dispose()
        {
            _connection.Close();
            _connection.Dispose();
        }
    }
}