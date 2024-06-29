using Control_de_gastos.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Control_de_gastos.Data.Repositories
{
    public interface IInventarioRepository
    {
        Task<IEnumerable<Inventario>> GetAllAsync();
        Task<Inventario> GetByIdAsync(int id);
        Task AddAsync(Inventario inventario);
        Task UpdateAsync(Inventario inventario);
        Task DeleteAsync(int id);
    }
}
