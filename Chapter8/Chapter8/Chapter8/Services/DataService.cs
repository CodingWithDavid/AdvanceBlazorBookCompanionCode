using Chapter8.Models;

namespace Chapter8.Services
{
    public class DataService : IDataService
    {
        private List<Item> items = Enumerable.Range(1, 10000).Select(i => new Item { Name = $"Item {i}" }).ToList();
        public async Task<List<Item>> GetItemsAsync(int page, int size)
        {
            List<Item> results = items
                    .Skip((page - 1) * size)
                    .Take(size)
                    .ToList();
            await Task.CompletedTask;
            return results;
        }

        public async Task<List<Item>> GetItemsAsync()
        {
            await Task.CompletedTask;
            return items;
        }
    }
}
 