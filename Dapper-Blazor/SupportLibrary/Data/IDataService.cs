using SupportLibrary.Models;

namespace SupportLibrary.Data
{
    public interface IDataService
    {
        Task<List<ITransactionModel>> ReadAllTransactions();
        Task<List<ITransactionModel>> ReadTransactionsByDate(DateTime startDate, DateTime endDate);
        Task<List<ITransactionModel>> ReadTransactionsByRegion(string region);

    }
}