using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller_VPAN.Models
{
    public class Auto
    {
        [Key]
        public int IdA { get; set; }
        public string Marca { get; set; }
        public int NumPuertas { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }


        [ForeignKey("MotorId")]

        public int IdMotor { get; set; }
        public Motor Motor { get; set; }

    }
}
