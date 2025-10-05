using BlazorPostgres.Data;
using BlazorPostgres.Models;
using BlazorPostgres.Repositories;
using System.Collections.Generic;

namespace BlazorPostgres.Interfaces
{
    public interface IProdutosRepositories
    {
        Task AddProdutoAsync(Produto Produto);
        Task DeleteProdutoAsync(global::System.Int32 id);
        Task<List<Produto>> GetAllProdutosAsync();
        Task<Produto> GetProdutoByIdAsync(global::System.Int32 id);
        Task UpdateProdutoAsync(Produto Produto);
    }

}