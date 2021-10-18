using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4_POO_VE202846
{
    public abstract class Registro
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
    public class Estudiante : Registro
    {

        string usuario;
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        string codigo;
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
    public class Docente : Registro
    {

        string usuario;
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        string codigo;
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        string materia;
        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
    }
}
