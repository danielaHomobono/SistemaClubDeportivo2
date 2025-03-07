﻿using System;
using System.Collections.Generic;

namespace SistemaClubDeportivo2.Entidades
{
    public class E_Pagar
    {
        public int IDPago { get; set; }
        public int NCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string FormaPago { get; set; }
        public int Cuotas { get; set; }
        public float Monto { get; set; }
        public DateTime FechaPago { get; set; }        
        public List<string> ActividadesInscritas { get; set; }
        public int IdInscri { get; set; }
        public bool EsSocio { get; set; }  
        public string TipoPago { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Cliente { get; set; }
        public bool EsCuotaMensual { get; set; }
        

        public E_Pagar()
        {
            ActividadesInscritas = new List<string>();
        }

    }
}
