using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }    
}
