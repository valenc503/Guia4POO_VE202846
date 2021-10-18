using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4_POO_VE202846
{
    public abstract class Figura
    {
        private double area;
        public Figura(double A)
        {
            area = A;
        }
        public double Area
        {
            get { return area; }
            set { area = value; }
        }
        public virtual void CalcularArea(System.Windows.Forms.Label LR)
        {

        }
    }
    public class Cuadrado : Figura
    {
        private double lado;
        public Cuadrado(double A, double L) : base(A)
        {
            lado = L;
        }
        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }
        public override void CalcularArea(System.Windows.Forms.Label LR)
        {
            Area = (Lado * Lado);
            LR.Text = "Area: " + Area;
        }
    }
    public class Circulo : Figura
    {
        private double radio;
        public Circulo(double A, double R) : base(A)
        {
            radio = R;
        }
        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }
        public override void CalcularArea(System.Windows.Forms.Label LR)
        {
            Area = (Math.PI * Math.Pow(Radio, 2));
            LR.Text = "Area: " + Area;
        }
    }
    public class Rombo : Figura
    {
        private double lado;
        private double lad2;
        public Rombo(double A, double P, double T) : base(A)
        {
            lado = P;
            lad2 = T;
        }
        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }
        public double Lado2
        {
            get { return lad2; }
            set { lad2 = value; }
        }
        public override void CalcularArea(System.Windows.Forms.Label LR)
        {
            Area = (Lado * Lado2) / 2;
            LR.Text = "Area: " + Area;
        }
    }
}
