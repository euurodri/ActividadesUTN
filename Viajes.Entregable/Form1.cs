using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntregablePancho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sistema sistema;
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            ModalAgregarTarjeta modal = new ModalAgregarTarjeta();
            
            while(modal.ShowDialog() == DialogResult.OK)
            {
                if(modal.tbDni.Text.Length>0 & modal.tbNombre.Text.Length > 0 & modal.tbDireccion.Text.Length>0)
                {
                 sistema.AgregarTarjeta(sistema.Random(),Convert.ToInt32(modal.tbDni.Text),modal.tbNombre.Text,modal.tbDireccion.Text);
                }
                else
                {
                    MessageBox.Show("Rellene los campos antes de continuar.");
                }
            modal.tbDni.Clear();modal.tbNombre.Clear();modal.tbDireccion.Clear();
            }
            modal.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sistema = new Sistema();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            BloquearTarjeta modal1 = new BloquearTarjeta();
            
            while(modal1.ShowDialog() == DialogResult.OK)
            {
                if (modal1.tbNumTarjeta.Text.Length > 0)
                {
                resultado=sistema.BloquearTarjeta(Convert.ToInt32(modal1.tbNumTarjeta.Text));
                    if (!resultado)
                    {
                        MessageBox.Show("El número de la tarjeta ingresada es inexistente.");
                    }
                    else
                    {
                        MessageBox.Show("La tarjeta fue borrada correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Rellene los campos antes de continuar.");
                }
                modal1.tbNumTarjeta.Clear();
            }
        }

        private void btnNumerosTarjeta_Click(object sender, EventArgs e)
        {
            string[] vectorNuevo = sistema.VerTarjetas();
            string nros = "";
            for(int i=0;i<vectorNuevo.Length;i++)
            {
                nros += vectorNuevo[i]+ "\n";
            }
            MessageBox.Show(nros);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarViajes modal2 = new AgregarViajes();
            string[] vectorTarjetas = sistema.VerTarjetas();
            for (int i = 0; i < vectorTarjetas.Length; i++)
            {
                modal2.cbNumTarjetas.Items.Add(vectorTarjetas[i]);
            }
            string[] vectorViajes = sistema.VerDestinos();
            for (int i = 0; i < vectorViajes.Length; i++)
            {
                modal2.cbViajes.Items.Add(vectorViajes[i]);
            }
            while (modal2.ShowDialog() == DialogResult.OK)
            {
                Viajes nuevoViaje = new Viajes(DateTime.Now,Convert.ToString(modal2.cbViajes.SelectedItem),Convert.ToInt32(modal2.cbLineas.SelectedItem));
                Tarjeta tarjetaBuscada=sistema.BuscarTarjeta(Convert.ToInt32(modal2.cbNumTarjetas.SelectedItem));
                if (tarjetaBuscada != null)
                {
                    tarjetaBuscada.AgregarViajes(nuevoViaje);
                }
                else{
                    MessageBox.Show("Tarjeta Inexistente.");
                }
                modal2.cbViajes.SelectedIndex = -1;modal2.cbNumTarjetas.SelectedIndex= -1;modal2.cbLineas.SelectedIndex = -1;
            }
        }

        private void btnMostrarViajes_Click(object sender, EventArgs e)
        {
            VerViajes verviajes = new VerViajes();
            string[] vectorTarjetas = sistema.VerTarjetas();
            for (int i = 0; i < vectorTarjetas.Length; i++)
            {
                verviajes.cbNros.Items.Add(vectorTarjetas[i]);
            }
            
            while (verviajes.ShowDialog() == DialogResult.OK)
            {
                verviajes.lbUltimos10.Items.Clear();
                if (verviajes.cbNros.SelectedIndex != -1)
                {
                        Tarjeta encontrada = sistema.BuscarTarjeta(Convert.ToInt32(verviajes.cbNros.SelectedItem));
                        string[] viajes = encontrada.MostrarViajes();
                        for (int i = 0; i < viajes.Length; i++)
                        {
                            verviajes.lbUltimos10.Items.Add(i + 1 + " " + viajes[i]);
                        }
                }
                else
                {
                    MessageBox.Show("Rellene el campo antes de continuar.");
                }
                verviajes.cbNros.SelectedIndex= -1;
            }
        }
    }
}
