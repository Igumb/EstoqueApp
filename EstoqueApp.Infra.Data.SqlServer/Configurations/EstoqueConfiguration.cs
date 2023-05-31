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
    public class EstoqueConfiguration : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nome).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Descricao).HasMaxLength(250).IsRequired();
        }
    }
}
