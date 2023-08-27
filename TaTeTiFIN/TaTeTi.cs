using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaTeTiFIN
{
    internal class TaTeTi
    {
        private string[,] tablero;
        private Jugador jugador1, jugador2;
        public Jugador Jugador1
        {
            get { return jugador1; }
        }
        public Jugador Jugador2
        {
            get { return jugador2; }
        }
        public string[,] Tablero
        {
            get { return tablero; }
        }
        public TaTeTi() : this("Maquina2")
        {

        }
        private void InicializarTablero()
        {
            tablero = new string[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    tablero[i, j] = "";
                }
            }
        }
        public void LimpiarMatriz()
        {
            InicializarTablero();
        }
        public TaTeTi(string nombre)
        {
            jugador1= new Jugador(this,"O",nombre);
            jugador2 = new Jugador(this, "X", "Maquina");
            InicializarTablero();
        }
        
        public bool MarcarTablero(string marca,int fila,int columna)
        {
            if (tablero[fila, columna] == "")
            {
                tablero[fila, columna] = marca;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool VerificarJugada(Jugador jugador)
        {
            bool puedeMarcar = false;
            ///verificar fila
            for(int fila=0;fila<3 && !puedeMarcar; fila++)
            {
                puedeMarcar=true;
                for(int columna=0;columna<3 && puedeMarcar; columna++)
                {
                    puedeMarcar &= tablero[fila, columna] == jugador.Marca;
                }
            }
            ///verificar columna
            for (int columna = 0; columna < 3 && !puedeMarcar; columna++)
            {
                puedeMarcar = true;
                for (int fila = 0; fila < 3 && puedeMarcar; fila++)
                {
                    puedeMarcar &= tablero[fila, columna] == jugador.Marca;
                }
            }
            ///verificar diagonal
            if (!puedeMarcar)//es falso
            {
                puedeMarcar = true;
                for (int n = 0; n < 3 && puedeMarcar; n++)
                {
                    puedeMarcar &= tablero[n, n] == jugador.Marca;
                }
            }

            ///verificar diagonal invertida
            if (!puedeMarcar)
            {
                int m = 2;
                puedeMarcar = true;
                for(int n=0;n<3 && puedeMarcar; n++)
                {
                    puedeMarcar &= tablero[n, m] == jugador.Marca;
                    m--;
                }
            }
            return puedeMarcar;
        }
        public Jugador HayGanador()
        {
            Jugador ganador = null;
            bool j1 = Jugador1.VerificarGanador();
            bool j2 = Jugador2.VerificarGanador();
            if (j1 && !j2)
            {
                ganador = Jugador1;
                Jugador1.AñadirVictoria();
            }else if (!j1 && j2)
            {
                ganador = Jugador2;
                Jugador2.AñadirVictoria();
            }
                return ganador;
        }
        public bool HaFinalizado()
        {
            int c = 0;
            for(int fila = 0; fila < 3; fila++)
            {
                for(int columna = 0; columna < 3; columna++)
                {
                    if (tablero[fila, columna] != "")
                    {
                        c++;
                    }
                }
            }
            return c == 8 || HayGanador() != null;
        }
    }
}
