using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaTeTiFIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Partida partida;
        Sistema sistema;
        Button[,] btnMatrix = new Button[3, 3];
        int fila, columna;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            gbTablero.Enabled = true;
            this.sistema = new Sistema(tbNombre.Text);
            
        }
       
        private void ConvertButtonToMap(Button sender, out int renglon, out int columna)
        {
            renglon = 0;
            columna = 0;
            switch (sender.TabIndex)
            {
                case 1: { renglon = 0; columna = 0; } break;
                case 2: { renglon = 0; columna = 1; } break;
                case 3: { renglon = 0; columna = 2; } break;
                case 4: { renglon = 1; columna = 0; } break;
                case 5: { renglon = 1; columna = 1; } break;
                case 6: { renglon = 1; columna = 2; } break;
                case 7: { renglon = 2; columna = 0; } break;
                case 8: { renglon = 2; columna = 1; } break;
                case 9: { renglon = 2; columna = 2; } break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!sistema.tateti.HaFinalizado())
            {
                ConvertButtonToMap(sender as Button, out fila, out columna);
                if (sistema.tateti.Jugador1.Jugar(fila, columna) == true)
                {
                    btnMatrix[sistema.tateti.Jugador1.UltimaFila, sistema.tateti.Jugador1.UltimaColumna].ImageIndex = 1;
                    if (sistema.tateti.HayGanador()==null) { 
                    while (sistema.tateti.Jugador2.Jugar() == false) ;
                    btnMatrix[sistema.tateti.Jugador2.UltimaFila, sistema.tateti.Jugador2.UltimaColumna].ImageIndex = 2;
                    }
                }
                else
                {
                    MessageBox.Show("Vuelva");
                }
            }
            else
            {
                
                Jugador ganador = sistema.tateti.HayGanador();
                if (ganador == null)
                {
                    MessageBox.Show("Empató");
                    this.partida = new Partida("-");
                }
                else
                {
                    MessageBox.Show("Ganador:" + ganador.Nombre);
                    this.partida = new Partida(ganador.Nombre);
                }
            }
            

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (partida!= null)
            {
                lbHistorial.Items.Add(partida.ToString());
            }
            else
            {
                lbHistorial.Items.Add("EMPATE.");
            }
            for (int f = 0; f < 3; f++)
                for (int c = 0; c < 3; c++)
                    btnMatrix[f, c].ImageIndex = 0;
            sistema.tateti.LimpiarMatriz();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnMatrix[0, 0] = button1;
            btnMatrix[0, 1] = button2;
            btnMatrix[0, 2] = button3;
            btnMatrix[1, 0] = button4;
            btnMatrix[1, 1] = button5;
            btnMatrix[1, 2] = button6;
            btnMatrix[2, 0] = button7;
            btnMatrix[2, 1] = button8;
            btnMatrix[2, 2] = button9;
        }
    }
}
