using System.ComponentModel.DataAnnotations;

namespace MultasTransito.Models
{
    public class Propietario
    {
        [Key]
        [Display(Name = "Número de NIT")]
        public int IdNit { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        [Display(Name = "Número de Licencia")]
        public int Licencia { get; set; }
        [Display(Name = "Número de teléfono")]
        public int Telefono { get; set; }
        [Display(Name = "Correo Electrónico")]
        public string Correo { get; set; }
    }
}
