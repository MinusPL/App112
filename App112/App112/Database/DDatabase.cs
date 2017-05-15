using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App112.Database
{
    public class DDatabase
    {
        readonly SQLiteAsyncConnection database;

        public DDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<DMessage>().Wait();
        }

        public Task<List<DMessage>> GetMessagesFromReport(string reportID)
        {
            return database.QueryAsync<DMessage>("SELECT * FROM [DMessage] WHERE [reportID] = {0}", reportID);
        }

        public Task<List<DReport>> GetReports()
        {
            return database.QueryAsync<DReport>("SELECT * FROM [DReport]");
        }

        public Task<int> AddReport(DReport report)
        {
            return database.InsertAsync(report);
        }

        public Task<int> AddMessage(DMessage message)
        {
            return database.InsertAsync(message);
        }
    }
}
