using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MultasTransito.Models
{
    public class Vehiculo
    {
        [Key]
        [Display(Name = "Número de placa")]
        public int IdPlaca { get; set; }   
        [Display(Name = "Color")]
        public string Color { get; set; }
        [Display(Name = "Número de NIT")]
        public int IdNit { get; set; }
        [Display(Name = "Marca")]
        public string Marca { get; set; }
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }
        [Display(Name = "Año")]
        public int Año { get; set; } 
        [Display(Name = "Número de multa")]
        public int IdMulta { get; set; }
        [Display(Name = "Tipo de placa")]
        public string TipoPlaca { get; set; }
        [Display(Name = "Número de placa")]
        public string NumeroPlaca { get; set; }        
    }
}
