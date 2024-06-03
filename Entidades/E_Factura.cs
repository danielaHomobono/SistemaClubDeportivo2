using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClubDeportivo2.Entidades
{
    public class E_Factura
    {
        public string NombreCliente { get; set; }
        public string FormaPago { get; set; }
        public float Monto { get; set; }
        public DateTime FechaPago { get; set; }
    }
}
