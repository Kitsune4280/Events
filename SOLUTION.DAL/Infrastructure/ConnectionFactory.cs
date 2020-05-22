using SOLUTION.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SOLUTION.DAL.Infrastructure
{
    public class ConnectionFactory : IConnectionFactory
    {
        private static string _connectionString;

        public IDbConnection GetConnection
        {
            get
            {
                SqlConnection connection;
                if (!string.IsNullOrEmpty(_connectionString))
                    connection = new SqlConnection(_connectionString);
                else
                    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Events"].ConnectionString);
                connection.Open();
                return connection;
            }
        }

        public void SetConnection(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
