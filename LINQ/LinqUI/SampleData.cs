using System;
using LinqUI.Models;

namespace LinqUI
{
    public static class SampleData
    {
        public static List<ContactModel> GetContactData()
        {
            List<ContactModel> output = new List<ContactModel>
            {
                new ContactModel{ 
                    Id = 1, 
                    FirstName = "Tim", 
                    LastName = "Corey",
                    Addresses = new List<int>{1,2,3} 
                },
                new ContactModel{ 
                    Id = 2, 
                    FirstName = "Joe", 
                    LastName = "Mama",
                    Addresses = new List<int>{1} 
                },
                new ContactModel{ 
                    Id = 3, 
                    FirstName = "Bob", 
                    LastName = "Dole",
                    Addresses = new List<int>{3} 
                },
                new ContactModel{ 
                    Id = 4, 
                    FirstName = "Panam", 
                    LastName = "Palmer",
                    Addresses = new List<int>{2} 
                },
                new ContactModel{ 
                    Id = 5, 
                    FirstName = "Judy", 
                    LastName = "Alvarez ",
                    Addresses = new List<int>{1,2} 
                }
            };
            return output;
        }

        public static List<AddressModel> 
    }
}