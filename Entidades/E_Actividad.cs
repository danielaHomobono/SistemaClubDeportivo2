using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClubDeportivo2.Entidades
{
    internal class E_Actividad
    {
        public int NActividad { get; set; }
        public string Nombre { get; set; }
        public int Cupo { get; set; }
        public float Precio { get; set; }
        public int NProfesor { get; set; }
    }
}
