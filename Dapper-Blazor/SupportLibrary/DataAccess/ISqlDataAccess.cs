using System;
using System.Collections.Generic;

namespace SupportLibrary.DataAccess
{
    public interface ISqlDataAccess
    {
        Task<List<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName);
        List<T> LoadDataAlternative<T, U>(string sqlStatement, U parameters, string connectionString);
        Task SaveData<T>(string storedProcedure, T parameters, string connectionStringName);
        void SaveDataAlternative<T>(string sqlStatement, T parameters, string connectionString);
    }
}