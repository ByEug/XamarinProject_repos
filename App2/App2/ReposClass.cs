using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using SQLite;
using Xamarin.Forms;

namespace App2
{
    public class PlayersAsyncRepository
    {
        SQLiteAsyncConnection database;
        
        public PlayersAsyncRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteAsyncConnection(databasePath);
            //database.CreateTable<PlayerRepos>();

        }

        public async Task CreateTable()
        {
            await database.CreateTableAsync<PlayerRepos>();
        }
        public async Task<List<PlayerRepos>> GetItemsAsync()
        {
            return await database.Table<PlayerRepos>().ToListAsync();

        }
        public async Task<PlayerRepos> GetItemAsync(int id)
        {
            return await database.GetAsync<PlayerRepos>(id);
        }
        public async Task<int> DeleteItemAsync(PlayerRepos item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(PlayerRepos item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
        /*public IEnumerable<PlayerRepos> GetItems()
        {
            return (from i in database.Table<PlayerRepos>() select i).ToList();

        }
        public PlayerRepos GetItem(int id)
        {
            return database.Get<PlayerRepos>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<PlayerRepos>(id);
        }
        public int SaveItem(PlayerRepos item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }*/

    }
}
