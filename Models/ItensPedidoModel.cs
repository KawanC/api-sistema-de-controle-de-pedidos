using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiSistemaControlePedidos.Models
{
    public class ItensPedidoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdItenPedido { get; set; }

        [ForeignKey("PedidoModel")]
        public int IdPedido { get; set; }
        public Int16 Qtd { get; set; }
        [ForeignKey("ProdutosModel")]
        public int IdProduto { get; set; }
        public string? Notas { get; set; }
    }
}
