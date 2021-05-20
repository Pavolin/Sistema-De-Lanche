using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeLanche.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeLanche.DAL.Mapeamento
{
    public class IngredienteMap : IEntityTypeConfiguration<Ingrediente>
    {
        public void Configure(EntityTypeBuilder<Ingrediente> builder)
        {
            builder.HasKey(e => e.IngredienteId);
            builder.Property(e => e.NomeIngrediente).HasMaxLength(50);
            builder.Property(e => e.NomeMontado).HasMaxLength(50);

            builder.ToTable("Ingredientes");
        }
    }
}
