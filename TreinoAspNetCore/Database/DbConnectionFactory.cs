using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;

namespace TreinoAspNetCore.Database
{
    public class DbConnectionFactory
    {
        private readonly string _connectionString;

        public DbConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public static SqlConnection CreateConnection(string connectionString)
        {
            var conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public SqlConnection CreateConnection()
        {
            var conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }

        public static DbConnectionFactory Create(string connectionString)
        {
            return new DbConnectionFactory(connectionString);
        }
    }
}
