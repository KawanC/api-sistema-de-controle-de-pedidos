using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiSistemaControlePedidos.Models
{
    public class StatusPedidoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 IdStatus { get; set; }
        public required string Status { get; set; }
    }
}
