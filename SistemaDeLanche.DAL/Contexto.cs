using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaDeLanche.BLL.Models;
using SistemaDeLanche.DAL.Mapeamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeLanche.DAL
{
    public class Contexto : IdentityDbContext
    {
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Lanche> Lanches { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new IngredienteMap());
            builder.ApplyConfiguration(new LancheMap());
        }
    }
}
