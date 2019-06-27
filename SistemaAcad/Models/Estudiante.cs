using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAcad.Models
{
    public class Estudiante
    {
        public int EstudianteID { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(20)]
        public string Codigo { get; set; }
    }
}
