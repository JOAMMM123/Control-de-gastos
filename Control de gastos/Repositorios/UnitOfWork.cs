using Control_de_gastos.Data.Repositories;
using System;
using System.Threading.Tasks;

namespace Control_de_gastos.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CONTROL_GASTOSContext _context;

        public UnitOfWork(CONTROL_GASTOSContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            Usuarios = new UsuarioRepository(_context);
            Proveedores = new ProveedorRepository(_context);
            Productos = new ProductoRepository(_context);
            Inventarios = new InventarioRepository(_context);
        }

        public IUsuarioRepository Usuarios { get; private set; }
        public IProveedorRepository Proveedores { get; private set; }
        public IProductoRepository Productos { get; private set; }
        public IInventarioRepository Inventarios { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
