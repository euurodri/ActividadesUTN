using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaTeTiFIN
{
    internal class Sistema
    {
        TaTeTi nuevo;
        ArrayList ListaPartidas = new ArrayList();
        public Sistema(string nombre)
        {
            if(nuevo == null)
            {
                nuevo=new TaTeTi(nombre);
            }
        }
        public TaTeTi tateti
        {
            get { return nuevo; }
        }
        public void AgregarPartida()
        {
            Partida fin = new Partida(nuevo.HayGanador().Nombre);
            ListaPartidas.Add(fin);
        }
        public ArrayList ListarPartidasOrdenadas()
        {
            return ListaPartidas;
        }

    }
}
