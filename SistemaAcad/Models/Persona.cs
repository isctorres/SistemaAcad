using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAcad.Models
{
    public class Persona
    {
        public int PersonaID { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(30)]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(20)]
        public string Nombres { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [StringLength(15)]
        public string Documento { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(15)]
        public string Telefono { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; }

        public bool Estado { get; set; }
    }
}
