using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAcad.Models
{
    public enum GradoEnum
    {
        Primero,
        Segundo,
        Tercero
    }
    public class Inscripcion
    {
        public int InscripcionID { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public GradoEnum Grado { get; set; }
        public int CursoID { get; set; }
        public int EstudianteID { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public decimal Pago { get; set; }
    }
}
