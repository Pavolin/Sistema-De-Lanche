using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaDeLanche.BLL.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        public string NomeLanche { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        public string Ingredientes { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public float ValorLanche { get; set; }
    }
}
