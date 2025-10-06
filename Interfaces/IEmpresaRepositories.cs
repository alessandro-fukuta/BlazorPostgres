 using System.Collections.Generic;
 using System.Threading.Tasks;
 using BlazorPostgres.Models;

namespace BlazorPostgres.Interfaces
{
    public interface IEmpresaRepositories
    {
        Task AddEmpresaAsync(Empresa empresa);
        Task DeleteEmpresaAsync(int id);
        Task<List<Empresa>> GetAllEmpresasAsync();
        Task<Empresa> GetEmpresaByIdAsync(int id);
        Task UpdateEmpresaAsync(Empresa empresa);
    }

}