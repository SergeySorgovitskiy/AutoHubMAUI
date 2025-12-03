using SQLite;

namespace AutoHub.Services.DbService
{
    public interface IDbService
    {
        SQLiteAsyncConnection GetConnection();
        Task InitializeAsync();
    }
}
