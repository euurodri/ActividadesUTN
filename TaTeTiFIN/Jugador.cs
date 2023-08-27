using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaTeTiFIN
{
    internal class Jugador
    {
        TaTeTi partida;
        static Random r = new Random();
        private string nombre, marca;
        int fila, columna;
        int victorias = 0;
        public int Victorias
        {
            get { return victorias; }
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public string Marca
        {
            get { return marca; }
        }
        public int UltimaFila
        {
            get { return fila; }
        }
        public int UltimaColumna
        {
            get { return columna; }
        }
        public Jugador(TaTeTi partida,string marca,string nombre)
        {
            this.partida= partida;
            this.marca= marca;
            this.nombre= nombre;
        }
        public void AñadirVictoria()
        {
            victorias++;
        }
        public bool Jugar(int fila,int columna)
        {
            this.fila= fila;
            this.columna= columna;
            return partida.MarcarTablero(marca, fila, columna);
        }
        public bool Jugar()
        {
          int fila=r.Next(3);
          int columna=r.Next(3);
          return Jugar(fila,columna);
        }
        public bool VerificarGanador()
        {
            return partida.VerificarJugada(this);
        }
    }
}
