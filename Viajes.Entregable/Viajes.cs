using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregablePancho
{
    internal class Viajes
    {
        private double precio=5000;
        double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        DateTime FechayHora { get; set; }
        string destino;
        public string Destino
        {
            get { return destino; }
        }
        int linea;
        public int Linea
        {
            get { return linea; }
        }
        public Viajes(DateTime fechayHora, string destino, int linea)
        {
            FechayHora = fechayHora;
            this.destino = destino;
            this.linea = linea;
        } 
        public override string ToString()
        {
            return String.Format("${0} - Destino:{1} - Linea:{2} - Fecha:{3:dd/MM/yyyy} - Hora:{4:HH:mm:ss}", precio, destino, linea, FechayHora.Date,FechayHora);         
        }
    }
}
