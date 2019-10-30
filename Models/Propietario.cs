using System.ComponentModel.DataAnnotations;

namespace MultasTransito.Models
{
    public class Propietario
    {
        [Key]
        public int IdNit { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Licencia { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
    }
}
