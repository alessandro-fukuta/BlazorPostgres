using BlazorPostgres.Data;
using BlazorPostgres.Models;
using BlazorPostgres.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlazorPostgres.Repositories
{
   
    public class ProdutosRepositories : IProdutosRepositories
    {
        private readonly ApplicationDbContext _context;

        public ProdutosRepositories(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Produto>> GetAllProdutosAsync()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> GetProdutoByIdAsync(int id)
        {
            return await _context.Produtos.FindAsync(id);
        }

        public async Task AddProdutoAsync(Produto Produto)
        {
            _context.Produtos.Add(Produto);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProdutoAsync(Produto Produto)
        {
            _context.Produtos.Update(Produto);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProdutoAsync(int id)
        {
            var Produto = await _context.Produtos.FindAsync(id);
            if (Produto != null)
            {
                _context.Produtos.Remove(Produto);
                await _context.SaveChangesAsync();
            }
        }
    }
}
