using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorPostgres.Models
{
    [Table("empresa")]
    public class Empresa
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime? DataFundacao { get; set; }
        public string LogotipoUrl { get; set; }

    }
}