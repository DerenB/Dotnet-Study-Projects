using System;
using System.IO;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace SqlServerUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All that remains");
            SQLCrud sql = new SQLCrud(GetConnectionString());

            ReadAllContacts(sql);

            ReadContact(sql, 1);
        }

        private static void ReadAllContacts(SQLCrud sql)
        {
            var rows = sql.GetAllContacts();

            foreach(var row in rows)
            {
                Console.WriteLine($"{row.Id}: {row.FirstName} {row.LastName}.");
            }
            Console.WriteLine("End Query.");
        }

        private static string GetConnectionString(string connectionStringName = "Default")
        {
            string output = "";

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            
            var config = builder.Build();

            output = config.GetConnectionString(connectionStringName);

            return output;
        }

        private static void ReadContact(SQLCrud sql, int contactId)
        {
            var contact = sql.GetFullContactById(contactId);

            Console.WriteLine($"{ contact.BasicInfo.Id }: { contact.BasicInfo.FirstName } { contact.BasicInfo.LastName }.");
            Console.WriteLine("End Query.");
        }
    }
}