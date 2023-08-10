namespace SupportLibrary.Models
{
    public interface ITransactionModel
    {
        int Id { get; set; }
        string Location { get; set; }
        string State { get; set; }
        DateTime TransactionDateTime { get; set; }
        decimal TransactionAmount { get; set; }
        Boolean ActiveLocation { get; set; }
    }
}