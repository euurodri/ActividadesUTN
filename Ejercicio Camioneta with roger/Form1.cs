using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjFernando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Vehiculo vehiculo;
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbEsCamioneta.Checked)
            {

                vehiculo = new Camioneta(tbMarca.Text,tbModelo.Text,tbPatente.Text,Convert.ToInt32(tbAño.Text), Convert.ToInt32(tbCapacidad.Text),tbTraccion.Text, Convert.ToInt32(tbCantidadRuedas.Text), Convert.ToInt32(tbPasajeros.Text), Convert.ToInt32(tbPotencia.Text),tbCombustible.Text, Convert.ToInt32(tbCilindrada.Text),Convert.ToInt32(tbNSerie.Text));
                if (cbMalacate.Checked)
                {
                    ((Camioneta)vehiculo).AgregarMalacate(new Malacate(Convert.ToInt32(tbCapMalacate.Text), tbControl.Text));
                }
            }
            else
            {
                vehiculo = new Vehiculo(tbTraccion.Text, Convert.ToInt32(tbCantidadRuedas.Text), Convert.ToInt32(tbPasajeros.Text));
            }
            lbVehiculos.Items.Add(vehiculo.EnTexto());
        }

        private void rbEsCamioneta_CheckedChanged(object sender, EventArgs e)
        {
            tbMarca.Enabled = true;
            tbModelo.Enabled = true;
            tbPasajeros.Enabled = true;
            tbPatente.Enabled = true;
            tbAño.Enabled = true;
            tbCapacidad.Enabled = true;
            tbPotencia.Enabled = true;
            tbCombustible.Enabled = true;
            tbCilindrada.Enabled = true;
            tbNSerie.Enabled = true;
            cbMalacate.Enabled = true;
            
        }


        private void cbMalacate_CheckedChanged(object sender, EventArgs e)
        {
            tbCapMalacate.Enabled = true;
            tbControl.Enabled = true;
        }
    }
}
