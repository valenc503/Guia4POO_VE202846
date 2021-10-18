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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form Menu = new FrmAlumno();
            Menu.Show();
            this.Hide();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form Menu = new FrmDocente();
            Menu.Show();
            this.Hide();
        }
    }
}
