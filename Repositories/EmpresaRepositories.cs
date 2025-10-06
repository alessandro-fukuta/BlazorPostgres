using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPostgres.Data;
using BlazorPostgres.Models;
using Microsoft.EntityFrameworkCore;
using BlazorPostgres.Interfaces;

namespace BlazorPostgres.Repositories
{
    public class EmpresaRepositories : IEmpresaRepositories
    {
        private readonly ApplicationDbContext _context;
        public EmpresaRepositories(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Empresa>> GetAllEmpresasAsync()
        {
            return await _context.Empresas.ToListAsync();
        }
        public async Task<Empresa> GetEmpresaByIdAsync(int id)
        {
            return await _context.Empresas.FindAsync(id);
        }
        public async Task AddEmpresaAsync(Empresa empresa)
        {
            _context.Empresas.Add(empresa);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateEmpresaAsync(Empresa empresa)
        {
            _context.Empresas.Update(empresa);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteEmpresaAsync(int id)
        {
            var empresa = await _context.Empresas.FindAsync(id);
            if (empresa != null)
            {
                _context.Empresas.Remove(empresa);
                await _context.SaveChangesAsync();
            }
        }
    }
}