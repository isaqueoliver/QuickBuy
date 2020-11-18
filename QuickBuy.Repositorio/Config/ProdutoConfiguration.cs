using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
            public void Configure(EntityTypeBuilder<Produto> builder)
            {
                builder.HasKey(x => x.Id);

                //Builder utiliza o padrão Fluent
                builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);
                builder.Property(x => x.Descricao).IsRequired().HasMaxLength(400);
                builder.Property(x => x.Preco).IsRequired();

                //builder.Property(x => x.Pedidos);
            }
    }
}
