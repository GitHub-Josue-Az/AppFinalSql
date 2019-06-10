using System;
using System.Collections.Generic;
using System.Text;

using SQLite;
using System.Threading.Tasks;


namespace AppFinalSqlite
{
   public class IncidenciasData
    {
        readonly SQLiteAsyncConnection database;

        public IncidenciasData(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Incidencias>().Wait();
        }

        public Task<List<Incidencias>> GetItemsAsync()
        {
            return database.Table<Incidencias>().ToListAsync();
        }

        public Task<List<Incidencias>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Incidencias>("SELECT * FROM [Incidencias] WHERE [Done] = 0");
        }

        public Task<Incidencias> GetItemAsync(int id)
        {
            return database.Table<Incidencias>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Incidencias item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Incidencias item)
        {
            return database.DeleteAsync(item);
        }

    }
}
