using ApiSistemaControlePedidos.Models;
using Microsoft.EntityFrameworkCore;

public class SistemaContext : DbContext
{
    // Construtor que aceita DbContextOptions
    public SistemaContext(DbContextOptions<SistemaContext> options) : base(options)
    {
    }

    public DbSet<PedidoModel> PedidoModel { get; set; }
    public DbSet<ItensPedidoModel> ItensPedidoModel { get; set; }
    public DbSet<StatusPedidoModel> StatusPedidoModel { get; set; }
    public DbSet<ProdutosModel> ProdutosModel { get; set; }
    public DbSet<TiposProdutoModel> TiposProdutoModel { get; set; }
    public DbSet<HorariosFuncionamentoModel> HorariosFuncionamentoModel { get; set; }

}