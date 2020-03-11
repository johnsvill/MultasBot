using System.ComponentModel.DataAnnotations;

namespace MultasTransito.Models
{
    public class Municipios
    {
        [Key]
        [Display(Name = "ID Municipalidad")]
        public int IdMunicipalidad { get; set; }
        [Required]
        [Display(Name = "Nombre de municipio")]
        public string Nombre { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }               
    }
}
