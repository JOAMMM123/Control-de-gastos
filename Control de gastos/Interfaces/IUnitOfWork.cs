using Control_de_gastos.Data.Repositories;
using System;
using System.Threading.Tasks;

namespace Control_de_gastos.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IUsuarioRepository Usuarios { get; }
        IProveedorRepository Proveedores { get; }
        IProductoRepository Productos { get; }
        IInventarioRepository Inventarios { get; }

        Task<int> CompleteAsync();
    }
}
