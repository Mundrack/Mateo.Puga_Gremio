using System.ComponentModel.DataAnnotations;

namespace Mateo.Puga_Examen_Progreso_I.Models
{
    public class MP
    {
        [Key] public int MPID { get; set; }
        [Required][MaxLength(10)] public required string MPNameLibro { get; set; }
        [MaxLength(100)] public required string MPDescription { get; set; }
        [requered] public DateTime MPFechaLimite { get; set; }
        public DateTime MPFechaRegistro { get; set; }
        [requered] public decimal MPPago { get; set; }

    }
}
