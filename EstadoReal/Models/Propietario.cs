using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EstadoReal.Models
{
    public class Propietario
    {
        [Key]
        public int IdPropietario { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public int Dni { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Correo { get; set; }
        [Required]
        public long Telefono { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Clave { get; set; }

        public byte EstadoPropietario { get; set; }
    }
}
