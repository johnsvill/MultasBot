using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MultasTransito.Models
{
    public class Vehiculo
    {
        [Key]
        public int IdPlaca { get; set; }        
        public string Color { get; set; }
        public int IdNit { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; } 
        public int IdMulta { get; set; }
        public string TipoPlaca { get; set; }
        public string NumeroPlaca { get; set; }        
    }
}
