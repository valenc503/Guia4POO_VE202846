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
    public partial class FrmUniversidad : Form
    {
        public FrmUniversidad()
        {
            InitializeComponent();
        }
        Alumno alumn = new Alumno();
        Universitario uni = new Universitario();
        Ingenieria inge = new Ingenieria();

        private void FrmUniversidad_Load(object sender, EventArgs e)
        {
            alumn.Listass.Add(new Alumno("Jose Mejilla", "Mejia@hotmail.com", "2536-8596", 19, 202523, 40));
            alumn.Listass.Add(new Alumno("Manuel Melara", "Manu@hotmail.com", "2234-7596", 18, 203423, 23));
            alumn.Listass.Add(new Alumno("Davud Ernesto", "David1@hotmail.com", "7826-8596", 19, 202323, 40));
            alumn.Listass.Add(new Alumno("Jose Artiga", "Art@hotmail.com", "6536-8596", 19, 207823, 40));
            uni.Listass.Add(new Universitario("Jaso castro", "Catro938@hotmail.com", "2536-8596", 19, "Universidad Benito", "Ingenieria en contabilidad", 4, 9, 8));
            uni.Listass.Add(new Universitario("Siliezar sanchez", "hgfd4@hotmail.com", "2564-8596", 19, "Universidad Soyapango", "Ingenieria en sistemas", 4, 9, 8));
            uni.Listass.Add(new Universitario("Chrisopher Muñoz", "kjhgf75@hotmail.com", "7836-8596", 19, "Universidad Soyapango", "Ingenieria industrial", 4, 9, 8));
            uni.Listass.Add(new Universitario("Jorge ortega", "losae23@hotmail.com", "9536-8596", 19, "Universidad Benito", "Ingenieria aeronautica", 4, 9, 8));
            inge.Listass.Add(new Ingenieria("Edwin melgar", "Melg@hotmail.com", "76636-8596", 19, "Especializacion idiomas", 952, 56));
            inge.Listass.Add(new Ingenieria("Jonathan vladimir", "Vlad205@hotmail.com", "7436-8596", 19, "Especializacion sistemas", 952, 56));
            inge.Listass.Add(new Ingenieria("Douglas geovany", "Pig503@hotmail.com", "7936-8596", 19, "Especializacion multimedia", 952, 56));
            inge.Listass.Add(new Ingenieria("Alexander granados", "coco@hotmail.com", "2346-8596", 19, "Especializacion comunicaciones", 952, 56));

            dataGridView1.DataSource = alumn.Listass;
            dataGridView1.DataSource = uni.Listass;
            dataGridView1.DataSource = inge.Listass;
        }

        private void FrmUniversidad_Load_1(object sender, EventArgs e)
        {
            //Obtenemos los datos ingresados en el textbox
            string busqueda = textBox1.Text;

            busqueda = busqueda.ToLower(); //Los hacemos en minusculas, para luego trabajar todo en minusculas

            if (busqueda.Equals("")) //Si no se ingresaron datos, devolver error
            {
                MessageBox.Show("Ingresa un dato en la búsqueda.");
            }
            else
            {

                if (busqueda.Equals("todos")) // Si la busqueda es igual a todos, mostramos todos los datos
                {
                    dataGridView1.DataSource = alumn.Listass;
                    dataGridView1.DataSource = uni.Listass;
                    dataGridView1.DataSource = inge.Listass;
                }
                else if (busqueda.Equals("alumno"))
                {
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre del 
                    dataGridView1.DataSource = alumn.Listass;
                }
                else if (busqueda.Equals("universitario"))
                {
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre 
                    dataGridView1.DataSource = uni.Listass;
                }
                else if (busqueda.Equals("ingenieria"))
                {
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre 
                    dataGridView1.DataSource = inge.Listass;
                }
                else
                {
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre 
                    dataGridView1.DataSource = alumn.Listass.FindAll(x => x.Nombres.ToString().ToLower() == busqueda || x.Correo.ToLower() == busqueda);
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre 
                    dataGridView1.DataSource = uni.Listass.FindAll(x => x.Nombres.ToString().ToLower() == busqueda || x.Telefono.ToLower() == busqueda);
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre 
                    dataGridView1.DataSource = inge.Listass.FindAll(x => x.Nombres.ToString().ToLower() == busqueda || x.Correo.ToLower() == busqueda);
                }
            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Form Menu = new FrmMenu();
            Menu.Show();
            this.Hide();
        }
    }
}
