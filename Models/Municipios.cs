using System.ComponentModel.DataAnnotations;

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
    }
}
