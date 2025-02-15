using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiSistemaControlePedidos.Models
{
    public class TiposProdutoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoProduto { get; set; }
        public required string TipoProduto { get; set; }
    }
}
