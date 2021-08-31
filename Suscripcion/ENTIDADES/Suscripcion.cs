using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Suscripcion
    {
        public int IdAsociacion { get; set; }
        public int IdSuscriptor { get; set; }
        public Suscriptor suscriptor { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaFin { get; set; }
        public string MotivoFin { get; set; }
    }
}
