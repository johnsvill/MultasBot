using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MultasTransito.Models
{
    public class Multas
    {
        [Key]
        [Display(Name = "ID Multa")]
        public int IdMulta { get; set; }
        [Required]
        [Display(Name = "ID Municipalidad")]
        public int IdMunicipalidad { get; set; }
        [Display(Name = "Descripción de la multa")]
        public string Descripcion { get; set; }
        [Display(Name = "Número de placa")]
        public int IdPlaca { get; set; }
        [Display(Name = "Número de NIT")]
        public int Idnit { get; set; }
        [Display(Name = "Monto")]
        public string Monto { get; set; }
        public List<Vehiculo> Vehiculos { get; set; } 
    }
}
