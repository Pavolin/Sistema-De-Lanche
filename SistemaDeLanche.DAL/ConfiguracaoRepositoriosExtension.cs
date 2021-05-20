using Microsoft.Extensions.DependencyInjection;
using SistemaDeLanche.DAL.Interfaces;
using SistemaDeLanche.DAL.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeLanche.DAL
{
    public static class ConfiguracaoRepositoriosExtension
    {
        public static void ConfigurarRepositorios(this IServiceCollection services)
        {
            services.AddTransient<IIngredienteRepositorio, IngredienteRepositorio>();
            services.AddTransient<ILancheRepositorio, LancheRepositorio>();
        }
    }
}
