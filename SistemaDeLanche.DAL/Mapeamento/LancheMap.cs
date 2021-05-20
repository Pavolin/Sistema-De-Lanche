using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeLanche.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeLanche.DAL.Mapeamento
{
    public class LancheMap : IEntityTypeConfiguration<Lanche>
    {
        public void Configure(EntityTypeBuilder<Lanche> builder)
        {
            builder.HasKey(e => e.LancheId);
            builder.Property(e => e.NomeLanche).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Ingredientes).IsRequired().HasMaxLength(50);
            builder.Property(e => e.ValorLanche).IsRequired();

            builder.ToTable("Lanches");
        }
    }
}
