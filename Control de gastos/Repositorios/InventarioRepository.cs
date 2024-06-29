using Control_de_gastos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Control_de_gastos.Data.Repositories
{
    public class InventarioRepository : IInventarioRepository
    {
        private readonly CONTROL_GASTOSContext _context;

        public InventarioRepository(CONTROL_GASTOSContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Inventario>> GetAllAsync()
        {
            return await _context.Inventarios.ToListAsync();
        }

        public async Task<Inventario> GetByIdAsync(int id)
        {
            return await _context.Inventarios.FindAsync(id);
        }

        public async Task AddAsync(Inventario inventario)
        {
            _context.Inventarios.Add(inventario);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Inventario inventario)
        {
            _context.Entry(inventario).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var inventario = await _context.Inventarios.FindAsync(id);
            _context.Inventarios.Remove(inventario);
            await _context.SaveChangesAsync();
        }
    }
}
