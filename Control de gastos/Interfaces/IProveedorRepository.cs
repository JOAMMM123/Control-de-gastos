using Control_de_gastos.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Control_de_gastos.Data.Repositories
{
    public interface IProveedorRepository
    {
        Task<IEnumerable<Proveedore>> GetAllAsync();
        Task<Proveedore> GetByIdAsync(int id);
        Task AddAsync(Proveedore proveedor);
        Task UpdateAsync(Proveedore proveedor);
        Task DeleteAsync(int id);
    }
}
