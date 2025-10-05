using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorPostgres.Models
{
    [Table("produtos")]
    public class Produto
    {
        public int id { get; set; }

        [Required(ErrorMessage = "DESCRIÇÃO é obrigatório")]
        [MaxLength(60, ErrorMessage = "Mínimo de {1} caracteres é obrigatório")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "CODIGO DE BARRAS é obrigatório")]
        [MaxLength(40, ErrorMessage = "Mínimo de {1} caracteres é obrigatório")]
        public string codigo_barra { get; set; }

        [Range(0, 10000000000, ErrorMessage = "o Campo deve conter de {1} e {2}")]
        public decimal preco_custo { get; set; }

        [Range(0, 10000000000, ErrorMessage = "o Campo deve conter de {1} e {2}")]
        public decimal preco_custo_medio { get; set; }

        [Range(0, 10000000000, ErrorMessage = "o Campo deve conter de {1} e {2}")]
        public decimal preco_venda_prazo { get; set; }

        [Range(0, 10000000000, ErrorMessage = "o Campo deve conter de {1} e {2}")]
        public decimal preco_venda_vista { get; set; }
        public int estoque { get; set; }

        // Foreign Key
        public int? categoriaID { get; set; }
        public Categoria? categoria { get; set; }

    }

}