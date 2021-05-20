using SistemaDeLanche.BLL.Models;
using SistemaDeLanche.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeLanche.DAL.Repositorios
{
    public class LancheRepositorio : RepositorioGenerico<Lanche>, ILancheRepositorio
    {
        private readonly Contexto _contexto;
        public LancheRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
