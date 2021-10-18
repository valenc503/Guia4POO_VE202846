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
    public partial class FrmAlumno : Form
    {
        public FrmAlumno()
        {
            InitializeComponent();
        }
        //prepara objeto para generar cuadro de dialogo de seleccion de archivo
        OpenFileDialog cuadroseleccion = new OpenFileDialog();

        /*listado que permite tener varios elementos de la clase Persona*/
        private List<Estudiante> registros = new List<Estudiante>();
        private int edit_indice = -1;
        //el índice para editar comienza en -1, esto significa que no hay ninguno seleccionado, esto servirá para el DataGridView.
        private void actualizarGrid()
        {
            dgvlistado.DataSource = null;
            dgvlistado.DataSource = registros; /*los nombres de columna que veremos son los de las propiedades*/

        }
        private void reseteo()
        {
            txtnombre.Clear();
            txtcodigo.Clear();
            txtusuario.Clear();
        }

        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvlistado.SelectedRows[0];
            int posicion = dgvlistado.Rows.IndexOf(selected); //almacena en cual fila estoy
            edit_indice = posicion; //copio esa variable en índice editado
            Estudiante materia = new Estudiante();
            materia = registros[posicion]; /*esta variable de tipo persona, se carga con los valores que le pasa el listado*/
            //lo que tiene el atributo se lo doy al textbox
            txtnombre.Text = materia.Nombre;
            txtcodigo.Text = materia.Codigo;
            txtusuario.Text = materia.Usuario;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //creo un objeto de la clase persona y guardo a través de las propiedades
            Estudiante alumno = new Estudiante();
            alumno.Nombre = txtnombre.Text;
            alumno.Usuario = txtusuario.Text;
            alumno.Codigo = txtcodigo.Text;

            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                registros[edit_indice] = alumno;
                edit_indice = -1;
            }
            else
            {

                registros.Add(alumno); /*al arreglo de Productos le agrego el objeto creado con todos los datos que recolecté*/

            }
            actualizarGrid();//llamamos al procedimiento que guarda en datagrid
            reseteo(); //llamamos al método que resetea
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                registros.RemoveAt(edit_indice);
                edit_indice = -1; //resetea variable a -1
                reseteo();
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Dar doble click sobre elemento para seleccionar y borrar ");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            reseteo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form Menu = new Form1();
            Menu.Show();
            this.Hide();
        }
    }
}
