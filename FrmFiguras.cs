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
    public partial class FrmFiguras : Form
    {
        public FrmFiguras()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Menu = new FrmMenu();
            Menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double L = double.Parse(textBox1.Text);
            double A = 0;
            Cuadrado cuadrado = new Cuadrado(A, L);
            cuadrado.CalcularArea(label4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double R = double.Parse(textBox2.Text);
            double A = 0;
            Circulo circulo = new Circulo(A, R);
            circulo.CalcularArea(label5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double P = double.Parse(textBox4.Text);
            double T = double.Parse(textBox5.Text);
            double A = 0;
            Rombo rombo = new Rombo(A, P, T);
            rombo.CalcularArea(label8);
        }
    }
}
