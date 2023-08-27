using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregablePancho
{ 
    internal class Tarjeta
    {
        private int viajesPisados = 0;
        private int nroTarjeta;

        ArrayList viajesRealizados = new ArrayList();
    public int getNroTarjeta
        {
            get { return nroTarjeta; }
        }
    public Tarjeta(string nombre,int dni,string direccion,int nroTarjeta)
        {
            this.nroTarjeta = nroTarjeta;
            Cliente cliente = new Cliente(nombre, dni, direccion);
        }
        public void AgregarViajes(Viajes viaje)
        {
            if (viajesRealizados.Count < 10)
            {
                viajesRealizados.Add(viaje);
            }
            else
            {
                if (viajesPisados == 9)
                {
                    viajesPisados = 0;
                }
                viajesRealizados[viajesPisados++] = viaje;
            }
        }
        public string[] MostrarViajes()
        {
            int contador=0;
            if (viajesRealizados.Count < 10)
            {
                contador = viajesRealizados.Count;
            }
            else
            {
                contador = 10;
            }
            string[] ultimosDiez=new string[contador];
            for (int i=0;i<contador;i++)
            {
                ultimosDiez[i] = viajesRealizados[i].ToString();
            }
            return ultimosDiez;
        }
        public override string ToString()
        {
            return nroTarjeta.ToString();
        }
    }
}
