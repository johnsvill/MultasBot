using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
