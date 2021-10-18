using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4_POO_VE202846
{
    public abstract class Vehiculo
    {
        string marca;
        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        string capacidad;
        public string Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        double kilometros;
        public double kilo
        {
            get { return kilometros; }
            set { kilometros = value; }
        }
        int anio;
        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }
        string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        private static List<Vehiculo> lista = new List<Vehiculo>();
        public List<Vehiculo> Lista
        { get => lista; set => lista = value; }

    }

    public class Auto : Vehiculo
    {
        int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        string altura;
        public string Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        string motor;
        public string Motor
        {
            get { return motor; }
            set { motor = value; }
        }
        private static List<Auto> lista1 = new List<Auto>();
        public List<Auto> Lista1
        { get => lista1; set => lista1 = value; }
        public Auto(int codigo, string modelo, string altura, string motor, string marca, string capacidad, double Kilo, int anio)
        {
            Codigo = codigo;
            Modelo = modelo;
            Altura = altura;
            Motor = motor;
            Marca = marca;
            Capacidad = capacidad;
            kilo = kilo;
            Anio = anio;
        }
        public Auto()
        {
            codigo = 0;
            Modelo = "";
            Altura = "";
            motor = "";
            Marca = "";
            Capacidad = "";
            kilo = 0;
            Anio = 0;
        }
    }
    public class Moto : Vehiculo
    {
        int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        string altura;
        public string Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        string motor;
        public string Motor
        {
            get { return motor; }
            set { motor = value; }
        }
        private static List<Moto> lista1 = new List<Moto>();
        public List<Moto> Lista2
        { get => lista1; set => lista1 = value; }
        public Moto(int codigo, string modelo, string altura, string motor, string marca, string capacidad, double Kilo, int anio)
        {
            Codigo = codigo;
            Modelo = modelo;
            Altura = altura;
            Motor = motor;
            Marca = marca;
            Capacidad = capacidad;
            kilo = kilo;
            Anio = anio;
        }
        public Moto()
        {
            codigo = 0;
            Modelo = "";
            Altura = "";
            motor = "";
            Marca = "";
            Capacidad = "";
            kilo = 0;
            Anio = 0;
        }
    }
    public class Bus : Vehiculo
    {
        int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        string altura;
        public string Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        string motor;
        public string Motor
        {
            get { return motor; }
            set { motor = value; }
        }
        private static List<Bus> lista1 = new List<Bus>();
        public List<Bus> Lista1
        { get => lista1; set => lista1 = value; }
        public Bus(int codigo, string modelo, string altura, string motor, string marca, string capacidad, double Kilo, int anio)
        {
            Codigo = codigo;
            Modelo = modelo;
            Altura = altura;
            Motor = motor;
            Marca = marca;
            Capacidad = capacidad;
            kilo = kilo;
            Anio = anio;
        }
        public Bus()
        {
            codigo = 0;
            Modelo = "";
            Altura = "";
            motor = "";
            Marca = "";
            Capacidad = "";
            kilo = 0;
            Anio = 0;
        }
    }
}
