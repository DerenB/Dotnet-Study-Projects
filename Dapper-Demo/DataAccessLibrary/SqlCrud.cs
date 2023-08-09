using System;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class SQLCrud
    {
        private readonly string _connectionString;
        private SqlDataAccess db = new SqlDataAccess();

        public SQLCrud(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<BasicContactModel> GetAllContacts()
        {
            string sql = "SELECT [Id], [FirstName], [LastName] FROM dbo.Contacts";

            return db.LoadData<BasicContactModel, dynamic>(sql, new { }, _connectionString);
            // { } creates a new anonymous object, use this when there are no parameters
            // return a list of "Basic Contact Model"
        }
    }
}