using LinqUI.Models;

namespace LinqUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // LambdaTests();
            LinqTests();
            Console.WriteLine("--- --- ---");
            Console.WriteLine("Done Processing");
            Console.ReadLine();
        }

        private static void LambdaTests()
        {
            var data = SampleData.GetContactData();

            var results1 = data.Where(x => x.Addresses.Count > 1);
            foreach (var item in results1)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }

            var results2 = data.Select(x => x.FirstName);
            foreach (var item in results2)
            {
                Console.WriteLine(item);
            }

            var results3 = data.Take(2);
            foreach (var item in results3)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }

            var results4 = data.Skip(2).Take(2);

            var results5 = data.OrderBy(X => X.LastName);

            var results6 = data.OrderByDescending(X => X.LastName);
        }

        private static void LinqTests()
        {
            var contacts = SampleData.GetContactData();
            var addresses = SampleData.GetAddressData();

            var results1 = (
                from c in contacts
                where c.Addresses.Count > 1
                select c
            );

            var results2 = (
                from c in contacts
                join a in addresses
                on c.Id equals a.ContactId
                select new { 
                    c.FirstName, c.LastName, a.City, a.State 
                }
            );
            foreach (var item in results2)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} lives in {item.City}, {item.State}");
            }

            var results3 = (
                from c in contacts
                select new
                {
                    c.FirstName,
                    c.LastName,
                    Addresses = addresses.Where(a => c.Addresses.Contains(a.Id))
                }
            );
            foreach(var item in results3)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} - {item.Addresses.Count()}");
            }
        }
    }
}