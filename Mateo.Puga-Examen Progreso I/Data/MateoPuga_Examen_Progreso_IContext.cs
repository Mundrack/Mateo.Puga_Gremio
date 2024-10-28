using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mateo.Puga_Examen_Progreso_I.Models;

namespace Mateo.Puga_Examen_Progreso_I.Data
{
    public class MateoPuga_Examen_Progreso_IContext : DbContext
    {
        public MateoPuga_Examen_Progreso_IContext (DbContextOptions<MateoPuga_Examen_Progreso_IContext> options)
            : base(options)
        {
        }

        public DbSet<Mateo.Puga_Examen_Progreso_I.Models.MP> MP { get; set; } = default!;
    }
}
