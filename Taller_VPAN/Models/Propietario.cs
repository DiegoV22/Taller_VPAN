using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller_VPAN.Models
{
    public class Propietario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public int FechaNacimiento { get; set; }
        public Boolean EsEcuatoriano { get; set; }
        [ForeignKey("AutoId")]

        public int IdA { get; set; }
        public Auto Auto { get; set; }
    }
}
