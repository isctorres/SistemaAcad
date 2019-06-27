using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAcad.Models
{
    public class Instructor
    {
        public int InstructorID { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(30)]
        public string Especialidad { get; set; }
    }
}
