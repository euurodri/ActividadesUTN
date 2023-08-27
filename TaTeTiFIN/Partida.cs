using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaTeTiFIN
{
    internal class Partida
    {
        private string ganador;
        static int c = 0;
        public string Ganador
        {
            get { return ganador; }
        }
        public Partida(string ganador)
        {
            this.ganador = ganador;
            c++;
        }
        public override string ToString()
        {
            return "Ronda:" + c + " -- Ganador:" + ganador;
        }
    }
}
