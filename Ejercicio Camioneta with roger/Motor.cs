using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjFernando
{
    internal class Motor
    {
        public Camioneta Camionetas
        {
            get; set;
        }
        public int Potencia
        {
            get; set;
        }
        public string TipoCombustible
        {
            get; set;
        }
        public int Cilindrada
        {
            get; set;
        }   
        public int Nserie
        {
            get; set;
        }

        public Motor(int potencia,string combustible,int cilindrada,int nserie) 
        {
            Potencia = potencia;
            TipoCombustible = combustible;
            Cilindrada = cilindrada;
            Nserie = nserie;
        }

    }
}
