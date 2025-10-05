using BlazorPostgres.Models;
using BlazorPostgres.Repositories;
using BlazorPostgres.Data;

namespace BlazorPostgres.Interfaces
{
    public interface ICategoriasRepositories
    {
        Task AddCategoriaAsync(Categoria categoria);
        Task DeleteCategoriaAsync(global::System.Int32 id);
        Task<List<Categoria>> GetAllCategoriasAsync();
        Task<Categoria> GetCategoriaByIdAsync(global::System.Int32 id);
        Task UpdateCategoriaAsync(Categoria categoria);
    }

}