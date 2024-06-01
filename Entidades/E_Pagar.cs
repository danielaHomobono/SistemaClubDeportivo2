using System;

namespace SistemaClubDeportivo2.Entidades
{
    internal class E_Pagar
    {
        public int IDPago { get; set; }
        public int NSocio { get; set; }
        public string FormaPago { get; set; }
        public int Cuotas { get; set; }
        public float Monto { get; set; }
        public DateTime FechaPago { get; set; }
    }
}
