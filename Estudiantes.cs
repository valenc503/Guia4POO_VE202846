using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4_POO_VE202846
{
 
    public abstract class Estudiantes
    {
        string nombres;
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        string correo;
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        string telefono;
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        int edad;
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        private static List<Estudiantes> lista = new List<Estudiantes>();
        public List<Estudiantes> Lista
        { get => lista; set => lista = value; }
    }
    public class Alumno : Estudiantes
    {
        int nCarnet;
        public int Carnet
        {
            get { return nCarnet; }
            set { nCarnet = value; }
        }
        int nivelestudio;
        public int NivelEstudio
        {
            get { return nivelestudio; }
            set { nivelestudio = value; }
        }
        private static List<Alumno> listas = new List<Alumno>();
        public List<Alumno> Listass
        {
            get => listas;
            set => listas = value;
        }
        public Alumno(string nombre, string correo, string telefono, int edad, int carnet, int estudio)
        {
            Nombres = nombre;
            Correo = correo;
            Telefono = telefono;
            Edad = edad;
            Carnet = carnet;
            NivelEstudio = estudio;
        }
        public Alumno()
        {
            Nombres = "";
            Correo = "";
            Telefono = "";
            Edad = 0;
            Carnet = 0;
            NivelEstudio = 0;
        }
    }
    public class Universitario : Estudiantes
    {
        string nombreu;
        public string NombreU
        {
            get { return nombreu; }
            set { nombreu = value; }
        }
        string carrera;
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        int materias;
        public int Materias
        {
            get { return materias; }
            set { materias = value; }
        }
        int notas;
        public int Notas
        {
            get { return notas; }
            set { notas = value; }
        }
        int cum;
        public int CUM
        {
            get { return cum; }
            set { cum = value; }
        }
        private static List<Universitario> listas = new List<Universitario>();
        public List<Universitario> Listass
        {
            get => listas;
            set => listas = value;
        }
        public Universitario(string nombre, string correo, string telefono, int edad, string nombreu, string carrera, int materias, int notas, int cum)
        {
            Nombres = nombre;
            Correo = correo;
            Telefono = telefono;
            Edad = edad;
            NombreU = nombreu;
            Carrera = carrera;
            Materias = materias;
            Notas = notas;
            CUM = cum;

        }
        public Universitario()
        {
            Nombres = "";
            Correo = "";
            Telefono = "";
            Edad = 0;
            NombreU = "";
            Carrera = "";
            Materias = 0;
            Notas = 0;
            CUM = 0;
        }
    }
    public class Ingenieria : Estudiantes
    {
        string nombreproyecto;
        public string Nombreproyecto
        {
            get { return nombreproyecto; }
            set { nombreproyecto = value; }
        }
        decimal totahora;
        public decimal Horastotal
        {
            get { return totahora; }
            set { totahora = value; }
        }
        decimal horacompletas;
        public decimal Horascompletas
        {
            get { return horacompletas; }
            set { horacompletas = value; }
        }
        private static List<Ingenieria> listas = new List<Ingenieria>();
        public List<Ingenieria> Listass
        {
            get => listas;
            set => listas = value;
        }
        public Ingenieria(string nombre, string correo, string telefono, int edad, string nombrepro, decimal tot, decimal hor)
        {
            Nombres = nombre;
            Correo = correo;
            Telefono = telefono;
            Edad = edad;
            Nombreproyecto = nombrepro;
            tot = Horastotal;
            hor = Horascompletas;

        }
        public Ingenieria()
        {
            Nombres = "";
            Correo = "";
            Telefono = "";
            Edad = 0;
            Nombreproyecto = "";
            Horastotal = 0;
            Horascompletas = 0;
        }
    }
}
