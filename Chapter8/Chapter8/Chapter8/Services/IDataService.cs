using Chapter8.Models;

namespace Chapter8.Services
{
    public interface IDataService
    {
        Task<List<Item>> GetItemsAsync(int page, int size);

        Task<List<Item>> GetItemsAsync();
    }
}