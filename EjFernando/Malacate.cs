using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjFernando
{
    internal class Malacate
    {
        public Camioneta Camioneta { get; set; }
        public int CapacidadTiro
        {
            get;set;
        }
        public string Control
        {
            get;set;
        }
        public Malacate(int capacidadTiro,string control)
        {
            CapacidadTiro= capacidadTiro;
            Control= control;
        }

    }
}
