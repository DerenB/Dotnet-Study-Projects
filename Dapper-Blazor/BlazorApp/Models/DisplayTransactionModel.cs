using System;
using SupportLibrary.Models;

namespace BlazorApp.Models
{
    public class DisplayTransactionModel : ITransactionModel
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string State { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public decimal TransactionAmount { get; set; }
        public Boolean ActiveLocation { get; set; }
    }
}