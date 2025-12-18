using AutoHub.MVVM.Models;
using AutoHub.Services.DbService;
using SQLite;

namespace AutoHub.Services.Repositories.ListingRepository
{
    public class ListingRepository(IDbService dbService) : IListingRepository
    {
        private SQLiteAsyncConnection Connection => dbService.GetConnection();

        public async Task<List<ListingModel>> GetListingsAsync(string? searchQuery = null)
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return await Connection.Table<ListingModel>()
                    .OrderByDescending(l => l.CreatedDate)
                    .ToListAsync();
            }

           
            var searchPattern = $"%{searchQuery}%";
            var sql = @"
                SELECT * FROM Listings 
                WHERE LOWER(Title) LIKE LOWER(?) 
                   OR LOWER(Subtitle) LIKE LOWER(?)
                   OR LOWER(Description) LIKE LOWER(?)
                   OR LOWER(Location) LIKE LOWER(?)
                   OR CAST(Year AS TEXT) LIKE ?
                   OR CAST(Price AS TEXT) LIKE ?
                   OR CAST(Mileage AS TEXT) LIKE ?
                   OR (CASE WHEN IsElectric = 1 THEN 'electric' ELSE 'gas' END) LIKE ?
                ORDER BY CreatedDate DESC";

            return await Connection.QueryAsync<ListingModel>(sql,
                searchPattern, searchPattern, searchPattern, searchPattern,
                searchPattern, searchPattern, searchPattern, searchPattern);
        }

        public async Task<ListingModel?> GetDetailsByIdAsync(int carId)
        {
            return await Connection.Table<ListingModel>()
                .Where(c => c.Id == carId)
                .FirstOrDefaultAsync();
        }

        public async Task<List<ListingModel>> GetFavoritesByUserIdAsync(int userId, string? searchQuery = null)
        {
            var favorites = await Connection.Table<FavoriteModel>()
                .Where(f => f.UserId == userId)
                .ToListAsync();

            var favoriteIds = favorites.Select(f => f.ListingId).ToList();

            if (favoriteIds.Count == 0)
                return new List<ListingModel>();

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return await Connection.Table<ListingModel>()
                    .Where(l => favoriteIds.Contains(l.Id))
                    .ToListAsync();
            }

           
            var searchPattern = $"%{searchQuery}%";
            var placeholders = string.Join(",", favoriteIds.Select((_, i) => "?"));
            var sql = $@"
                SELECT * FROM Listings 
                WHERE Id IN ({placeholders})
                  AND (
                    LOWER(Title) LIKE LOWER(?) 
                    OR LOWER(Subtitle) LIKE LOWER(?)
                    OR LOWER(Description) LIKE LOWER(?)
                    OR LOWER(Location) LIKE LOWER(?)
                    OR CAST(Year AS TEXT) LIKE ?
                    OR CAST(Price AS TEXT) LIKE ?
                    OR CAST(Mileage AS TEXT) LIKE ?
                    OR (CASE WHEN IsElectric = 1 THEN 'electric' ELSE 'gas' END) LIKE ?
                  )";

            var parameters = favoriteIds.Cast<object>().ToList();
            parameters.AddRange(new[] {
                searchPattern, searchPattern, searchPattern, searchPattern,
                searchPattern, searchPattern, searchPattern, searchPattern
            });

            return await Connection.QueryAsync<ListingModel>(sql, parameters.ToArray());
        }

        public async Task AddListingAsync(ListingModel newListing)
        {
            await Connection.InsertAsync(newListing);
        }

        public async Task UpdateListingAsync(ListingModel listing)
        {
            listing.UpdatedDate = DateTime.Now;
            await Connection.UpdateAsync(listing);
        }

        public async Task DeleteListingAsync(int listingId)
        {
            await Connection.DeleteAsync<ListingModel>(listingId);
        }

        public async Task<List<ListingModel>> GetListingsByUserIdAsync(int userId, string? searchQuery = null)
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return await Connection.Table<ListingModel>()
                    .Where(l => l.SellerUserId == userId)
                    .OrderByDescending(l => l.CreatedDate)
                    .ToListAsync();
            }

            
            var searchPattern = $"%{searchQuery}%";
            var sql = @"
                SELECT * FROM Listings 
                WHERE SellerUserId = ?
                  AND (
                    LOWER(Title) LIKE LOWER(?) 
                    OR LOWER(Subtitle) LIKE LOWER(?)
                    OR LOWER(Description) LIKE LOWER(?)
                    OR LOWER(Location) LIKE LOWER(?)
                    OR CAST(Year AS TEXT) LIKE ?
                    OR CAST(Price AS TEXT) LIKE ?
                    OR CAST(Mileage AS TEXT) LIKE ?
                    OR (CASE WHEN IsElectric = 1 THEN 'electric' ELSE 'gas' END) LIKE ?
                  )
                ORDER BY CreatedDate DESC";

            return await Connection.QueryAsync<ListingModel>(sql,
                userId, searchPattern, searchPattern, searchPattern, searchPattern,
                searchPattern, searchPattern, searchPattern, searchPattern);
        }
    }
}