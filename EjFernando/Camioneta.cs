using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjFernando
{
    internal class Camioneta:Vehiculo
    {
        Motor motor;
        public string Marca
        {
            get; set;
        }
        public string Modelo
        {
            get; set;
        }

        public string Patente
        {
            get; set;
        }

        public int AñoFabricacion
        {
            get; set;
        }
        public int CapacidadCarga
        {
            get; set;
        }
        public Motor Motor
        {
            get { return motor; }
        }
        public Malacate Malacate
        {
            get { return Malacate; }
            set { Malacate = value; }
        }

        public Camioneta(string marca, string modelo, string patente, int añoFabricacion, int capacidadCarga,string traccion,int cantruedas,int pasajeros,int potencia,string combustible,int cilindrada,int nSerie):base(traccion,cantruedas,pasajeros)
        {
            Marca = marca;
            Modelo = modelo;
            Patente = patente;
            AñoFabricacion = añoFabricacion;
            CapacidadCarga = capacidadCarga;
            motor = new Motor(potencia,combustible,cilindrada,nSerie);
            motor.Camionetas = this;
        }
        public override string EnTexto()
        {
            return base.EnTexto()+String.Format(" - Marca:{0} - Modelo:{1} - Patente:{2} - Año:{3} - Capacidad:{4}", Marca,Modelo,Patente,AñoFabricacion,CapacidadCarga);
        }
    }
}
