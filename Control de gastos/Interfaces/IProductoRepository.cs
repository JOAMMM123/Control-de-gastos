using Control_de_gastos.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Control_de_gastos.Data.Repositories
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> GetAllAsync();
        Task<Producto> GetByIdAsync(int id);
        Task AddAsync(Producto producto);
        Task UpdateAsync(Producto producto);
        Task DeleteAsync(int id);
    }
}
