using System.ComponentModel.DataAnnotations;

namespace Taller_VPAN.Models
{
    public class Motor
    {
        [Key]
        public int IdMotor { get; set; }
        public string TipoMotor { get; set; }
        public int CaballosFuerza { get; set; }
        public int AnioFabricacion { get; set; }
       

    }
}
