using System;
using System.Linq;
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

        public FullContactModel GetFullContactById(int id)
        {
            string sql = "SELECT [Id], [FirstName], [LastName] FROM dbo.Contacts WHERE [Id] = @Id";
            FullContactModel output = new FullContactModel();

            output.BasicInfo = db.LoadData<BasicContactModel, dynamic>(sql, new { Id = id }, _connectionString).FirstOrDefault();

            if(output.BasicInfo == null)
            {
                // Do something that tells the user that the record was not found
                throw new Exception("User not found.");
            }

            sql = @"SELECT e.*, ce.*
                FROM dbo.EmailAddresses e
                INNER JOIN dbo.ContactEmail ce on ce.EmailAddressId = e.Id
                where ce.ContactId = @Id";

            output.EmailAddresses = db.LoadData<EmailAddressModel, dynamic>(sql, new { Id = id}, _connectionString);

            sql = @"SELECT p.*, cp.*
                FROM dbo.PhoneNumbers p
                INNER JOIN dbo.ContactPhoneNumbers cp on cp.PhoneNumberId = p.Id
                where cp.ContactId = @Id";

            output.PhoneNumbers = db.LoadData<PhoneNumberModel, dynamic>(sql, new { Id = id}, _connectionString);

            return output;
        }
    
        public void CreateContact(FullContactModel contact)
        {
            
        }
    }
}