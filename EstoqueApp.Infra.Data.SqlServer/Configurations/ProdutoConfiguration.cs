using EstoqueApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Infra.Data.SqlServer.Configurations
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Preco).HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(p => p.Quantidade).IsRequired();
            builder.Property(p => p.EstoqueId).IsRequired();

            builder.HasOne(p => p.Estoque)
                .WithMany(e => e.Produtos)
                .HasForeignKey(p => p.EstoqueId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
