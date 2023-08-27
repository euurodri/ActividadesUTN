using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregablePancho
{
    internal class Sistema
    {
        ArrayList viajesDisponibles = new ArrayList() {"Nordelta","Once","Palermo","Varela","Merlo","Belgrano","La Matanza","Caseros","San Martin","San Telmo","Paraná","Villa María","Cerrito","Haití"};
        Random r = new Random();
        ArrayList tarjetasRegistradas=new ArrayList();
        
        public string[] VerDestinos()
        {
            string[] verDestinos = new string[viajesDisponibles.Count];
            int cont = 0;
            foreach (string i in viajesDisponibles)
            {
                verDestinos[cont] = i;
                cont++;
            }
            return verDestinos;
        }
        public Tarjeta BuscarTarjeta(int nro)
        {
            Tarjeta tarjetita = null;
            int i = 0;
            bool bandera = false;
            while(i<tarjetasRegistradas.Count & bandera!=true)
            {
                if (nro == ((Tarjeta)tarjetasRegistradas[i]).getNroTarjeta)
                {
                    bandera = true;
                    tarjetita = ((Tarjeta)tarjetasRegistradas[i]);
                }
                i++;
            }
            return tarjetita;
        }
        public string[] VerTarjetas()
        {
            string[] nroTarjetas = new string[tarjetasRegistradas.Count];
            int cont = 0;
            foreach(Tarjeta i in tarjetasRegistradas)
            {
                nroTarjetas[cont] = i.ToString();
                cont++;
            }
            return nroTarjetas;
        }
        public void AgregarTarjeta(int num,int dni,string nombre,string direccion)
        {
            Tarjeta tarjeta = new Tarjeta(nombre,dni,direccion,num);
            tarjetasRegistradas.Add(tarjeta);
        }
        public int Random()
        {
            return r.Next(999999999);
        }
        public bool BloquearTarjeta(int numTarjeta)
        {
            int i = 0;
            bool bandera = false;
            while(bandera==false & i < tarjetasRegistradas.Count)
            {
                if (((Tarjeta)tarjetasRegistradas[i]).getNroTarjeta == numTarjeta)
                {
                    tarjetasRegistradas.RemoveAt(i);
                    bandera=true;
                }
                i++;
            }
            return bandera;
        }
    }
}
