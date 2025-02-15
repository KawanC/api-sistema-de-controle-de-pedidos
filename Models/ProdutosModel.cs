using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiSistemaControlePedidos.Models
{
    public class ProdutosModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduto { get; set; }
        public required string NomeProduto { get; set; }
        [ForeignKey("TiposProdutoModel")]
        public int IdTipoProduto { get; set; }
    }
}
