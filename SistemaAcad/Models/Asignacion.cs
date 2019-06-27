using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAcad.Models
{
    public class Asignacion
    {
        public int AsignacionID { get; set; }
        public int CursoID { get; set; }
        public int InstructorID { get; set; }

        [Required(ErrorMessage="Campo Obligatorio")]
        public DateTime Fecha { get; set; }
    }
}
