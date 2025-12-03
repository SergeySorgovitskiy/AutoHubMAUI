using SQLite;
using AutoHub.MVVM.Models;

namespace AutoHub.Services.DbService
{
    public class DbService : IDbService
    {
        private SQLiteAsyncConnection? _connection;
        public SQLiteAsyncConnection GetConnection()
        {
            if (_connection == null)
            {
                var dbPath = Path.Combine(FileSystem.AppDataDirectory, "autohub.db3");
                _connection = new SQLiteAsyncConnection(dbPath, SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache);
            }
            return _connection;
        }
        public async Task InitializeAsync()
        {
            var connection = GetConnection();
            await connection.CreateTableAsync<UserModel>();
            await connection.CreateTableAsync<ListingModel>();
            await connection.CreateTableAsync<FavoriteModel>();
        }
    }
}
