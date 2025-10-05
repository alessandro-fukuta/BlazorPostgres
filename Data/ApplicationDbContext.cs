using Microsoft.EntityFrameworkCore;
using BlazorPostgres.Models;

namespace BlazorPostgres.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /* referencia das classes que representam as tabelas de dados  */
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        
    }
}
