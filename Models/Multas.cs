using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MultasTransito.Models
{
    public class Multas
    {
        [Key]
        public int IdMulta { get; set; }
        [Required]
        public int IdMunicipalidad { get; set; }
        public string Descripcion { get; set; }
        public int IdPlaca { get; set; }
        public int Idnit { get; set; }
        public List<Vehiculo> Vehiculos { get; set; } 
    }
}
