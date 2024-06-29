using Control_de_gastos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Control_de_gastos.Data.Repositories
{
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly CONTROL_GASTOSContext _context;

        public ProveedorRepository(CONTROL_GASTOSContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Proveedore>> GetAllAsync()
        {
            return await _context.Proveedores.ToListAsync();
        }

        public async Task<Proveedore> GetByIdAsync(int id)
        {
            return await _context.Proveedores.FindAsync(id);
        }

        public async Task AddAsync(Proveedore proveedor)
        {
            _context.Proveedores.Add(proveedor);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Proveedore proveedor)
        {
            _context.Entry(proveedor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var proveedor = await _context.Proveedores.FindAsync(id);
            _context.Proveedores.Remove(proveedor);
            await _context.SaveChangesAsync();
        }
    }
}
