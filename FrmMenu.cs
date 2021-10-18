using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia4_POO_VE202846
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Menu = new Form1();
            Menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Menu = new FrmUniversidad();
            Menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Menu = new FrmFiguras();
            Menu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Menu = new FrmVehiculo();
            Menu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
