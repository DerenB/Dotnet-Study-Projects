using System;

namespace SupportLibrary.Models
{
    public class TransactionModel : ITransactionModel
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string State { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public decimal TransactionAmount { get; set; }
        public Boolean ActiveLocation { get; set; }
    }
}