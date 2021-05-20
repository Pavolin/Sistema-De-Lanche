using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaDeLanche.BLL.Models
{
    public class Ingrediente
    {
        public int IngredienteId { get; set; }

        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        public string NomeIngrediente { get; set; }

        public float ValorIngrediente { get; set; }

        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        public string NomeMontado { get; set; }

        public string IngrdientesUsados { get; set; }

        public float ValorMontado { get; set; }
    }
}
