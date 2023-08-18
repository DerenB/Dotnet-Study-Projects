using System.Globalization;
using CsvDemo;
using CsvHelper;

string inputFile = @"C:\Users\dboze\Documents\LocalRepo\Dotnet\Dotnet-Study-Projects\CSVHelper\people-100.csv";
string outputFile = @"C:\Users\dboze\Documents\LocalRepo\Dotnet\Dotnet-Study-Projects\CSVHelper\filtered-people.csv";

List<PersonModel> outputRecords = new();

// Read CSV file
using var reader = new StreamReader(inputFile);
using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);













