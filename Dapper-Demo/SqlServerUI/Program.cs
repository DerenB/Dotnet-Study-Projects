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
        }

        private static void ReadAllContacts(SQLCrud sql)
        {
            var rows = sql.GetAllContacts();

            foreach(var row in rows)
            {
                Console.WriteLine($"{row.Id}: {row.FirstName} {row.LastName}.");
            }
        }

        private static string GetConnectionString(string connectionStringName = "Default")
        {
            string output = "";

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            
            var config = builder.Build();

            output = config.GetConnectionString(connectionStringName);

            return output;
        }
    }
}