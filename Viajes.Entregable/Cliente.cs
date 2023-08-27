using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregablePancho
{
    internal class Cliente
    {
        private string nombre;
        private int dni;
        private string direccion;
        public int Dni
        {
            get { return dni; }
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public Cliente(string nombre,int dni,string direccion)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.direccion= direccion;
        }

    }
}
