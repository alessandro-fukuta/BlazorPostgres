using BlazorPostgres.Data;
using BlazorPostgres.Models;
using BlazorPostgres.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlazorPostgres.Repositories
{
    
    public class CategoriasRepositories : ICategoriasRepositories
    {
        private readonly ApplicationDbContext _context;

        public CategoriasRepositories(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Categoria>> GetAllCategoriasAsync()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task<Categoria> GetCategoriaByIdAsync(int id)
        {
            return await _context.Categorias.FindAsync(id);
        }

        public async Task AddCategoriaAsync(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategoriaAsync(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoriaAsync(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);
            if (categoria != null)
            {
                _context.Categorias.Remove(categoria);
                await _context.SaveChangesAsync();
            }
        }
    }
}
