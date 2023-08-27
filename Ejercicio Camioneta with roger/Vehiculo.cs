using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjFernando
{
    internal class Vehiculo
    {
        public string Traccion
        {
            get;set;
        }
        public int CantRuedas
        {
            get;set;
        }
        public int Pasajeros
        {
            get; set;
        }
        public Vehiculo(string traccion,int cantruedas,int pasajeros)
        {
            Traccion = traccion;
            CantRuedas=cantruedas;
            Pasajeros=pasajeros;
        }
        public virtual string EnTexto()
        {
            return String.Format("Tracción:{0} - Cantidad de Ruedas:{1} - Pasajeros: {2}",Traccion,CantRuedas,Pasajeros);
        }
    }
}
