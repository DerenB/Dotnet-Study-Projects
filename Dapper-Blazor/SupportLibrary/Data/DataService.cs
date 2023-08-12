using System;
using System.Linq;
using System.Threading.Tasks;
using SupportLibrary.Models;
using SupportLibrary.DataAccess;

namespace SupportLibrary.Data
{
    public class DataService : IDataService
    {
        private readonly ISqlDataAccess _dataAccess;

        public DataService(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<List<ITransactionModel>> ReadAllTransactions()
        {
            var transactions = await _dataAccess.LoadData<TransactionModel, dynamic>
                ("spTransactions_ReadAll", new { }, "Default");
            return transactions.ToList<ITransactionModel>();
        }

        public async Task<List<ITransactionModel>> ReadTransactionsByDate(DateTime startDate, DateTime endDate)
        {
            var transactions = await _dataAccess.LoadData<TransactionModel, dynamic>
                ("spTransactions_BetweenDates", new { @startDate = startDate, @endDate = endDate}, "Default");
            return transactions.ToList<ITransactionModel>();
        }

        public async Task<List<ITransactionModel>> ReadTransactionsByRegion(string region)
        {
            var transactions = await _dataAccess.LoadData<TransactionModel, dynamic>
                ("spTransactions_ReadByState", new { @state = region }, "Default");
            return transactions.ToList<ITransactionModel>();
        }
    }
}
