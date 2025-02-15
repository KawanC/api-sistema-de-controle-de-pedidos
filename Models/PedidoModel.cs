using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiSistemaControlePedidos.Models
{
    public class PedidoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public DateTime DtRegister { get; set; }

        [ForeignKey("StatusPedidoModel")]
        public Int16 IdStatus { get; set; }
        public required ICollection<ItensPedidoModel> ItensPedido { get; set; }

    }
}
