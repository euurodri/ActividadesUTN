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
    public partial class Tablero : Form
    {
        public Tablero()
        {
            InitializeComponent();
        }
        Button[,] btnMatrix = new Button[3, 3];
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Tablero_Load(object sender, EventArgs e)
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
