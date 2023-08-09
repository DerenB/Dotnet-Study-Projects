using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace DataAccessLibrary
{
    public class SqlDataAccess
    {
        public List<T> LoadData<T, U>(string sqlStatement, U parameters, string connectionString)
        {
            using(IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatement, parameters).ToList();
                return rows;
            }
            /*
            * Creates a connection to the database with the "using" statement
            * Using statement allows you to ensure the connection is always closed out properly
            * Once connection made, going to run "Query" method (from Dapper)
            * Query runs "sqlStatement"
            * Uses parameters like ID
            * <T> is a generic, we can pass in a model
            */
        }
        public void SaveData<T>(string sqlStatement, T parameters, string connectionString)
        {
            using(IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(sqlStatement, parameters);
            }
        }
    }
}
