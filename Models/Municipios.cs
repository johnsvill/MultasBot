using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultasTransito.Models
{
    public class Municipios
    {
        [Key]
        public int IdMunicipalidad { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
        public bool IsChecked { get; set; }
        public List<Municipios> MunicipiosSelect { get; set; }
    }    
}
