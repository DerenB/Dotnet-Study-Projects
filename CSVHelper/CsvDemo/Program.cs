using System.Globalization;
using CsvDemo;
using CsvHelper;

namespace CsvDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string inputFile = @"C:\Users\dboze\Documents\LocalRepo\Dotnet\Dotnet-Study-Projects\CSVHelper\people-100.csv";
            string outputFile = @"C:\Users\dboze\Documents\LocalRepo\Dotnet\Dotnet-Study-Projects\CSVHelper\filtered-people.csv";
            List<PersonModel> outputRecords = new();

            // Create a stream connection to the CSV file
            using var reader = new StreamReader(inputFile);

            // Reads the CSV
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            // Gets the records
            var records = csv.GetRecords<PersonModel>();

            foreach (var record in records)
            {
                if(record.FirstName.StartsWith("S"))
                {
                    outputRecords.Add(record);
                }
                //Console.WriteLine(record.FirstName + " " + record.LastName);
            }
            Console.WriteLine($"Number of records: {outputRecords.Count}.");

            // Output CSV
            using var writer = new StreamWriter(outputFile); // Opens stream to the output CSV file
            using var csvOut = new CsvWriter(writer, CultureInfo.InvariantCulture); // Writes to the file
            csvOut.WriteRecords(outputRecords);
        }
    }
}











