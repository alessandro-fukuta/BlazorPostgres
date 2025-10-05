using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorPostgres.Models
{
    [Table("categorias")]
    public class Categoria
    {
        public int id { get; set; }
        public string nome { get; set; }
    }

}