using SistemaDeLanche.BLL.Models;
using SistemaDeLanche.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeLanche.DAL.Repositorios
{
    public class IngredienteRepositorio : RepositorioGenerico<Ingrediente>, IIngredienteRepositorio
    {
        private readonly Contexto _contexto;
        public IngredienteRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
