using Product.API.Models;

namespace Product.API.IRepository
{
    public interface IProductRepository
    {
        Task<IEnumerable<MyProduct>> GetAllAsync();
        Task<MyProduct> GetByIdAsync(int id);
        Task AddAsync(MyProduct product);
        Task UpdateAsync(MyProduct product);
        Task DeleteAsync(int id);
    }
}
