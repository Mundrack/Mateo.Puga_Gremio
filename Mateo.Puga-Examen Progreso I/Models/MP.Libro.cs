﻿using System.ComponentModel.DataAnnotations;

namespace Mateo.Puga_Examen_Progreso_I.Models
{
    public class MP
    {
        public int MP_LibroID { get; set; }

        [requered]
        [MaxLength(100)]
        public string? MP_NombreLibro { get; set; }

        [requered][MaxLength(100)]
        public string? MP_Autor { get; set; }
        [requered]

        public decimal MP_HoraAgregacion { get; set; }
        [Range(1, 15)]
        public int MP_FechaPublicacion { get; set; }
        [requered]
        public bool MP_Nuevo {  get; set; }
        
    }
}
