using System.ComponentModel.DataAnnotations;

namespace MultasTransito.Models
{
    public class Vehiculo
    {
        [Key]
        public int IdPlaca { get; set; }
        [Required]
        public string Color { get; set; }
        public int IdNit { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string TipoPlaca { get; set; }
        public virtual Multas Multas { get; set; }
    }
}
