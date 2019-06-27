using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAcad.Models
{
    public class Curso
    {
        public int CursoID { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public int CategoriaID { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(512)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public byte Creditos { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public byte Horas { get; set; }
    }
}
