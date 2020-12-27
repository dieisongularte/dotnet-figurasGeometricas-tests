using System;

namespace dotnet_figurasGeometricas_tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo tr = new Triangulo
            {
                @base = 5,
                altura = 3
            };

            Quadrado q = new Quadrado
            {
                lado = 10
            };

            Circunferencia c = new Circunferencia
            {
                raio = 12
            };

            Trapezio tp = new Trapezio
            {
                baseMaior = 10,
                baseMenor = 5,
                altura = 6
            };

            double area = tr.CalcularArea();
            Console.WriteLine("Area Triângulo: " + area);

            area = q.CalcularArea();
            Console.WriteLine("Area Quadrado: " + area);

            area = c.CalcularArea();
            Console.WriteLine("Area Circunferência: " + area.ToString("F"));

            area = tp.CalcularArea();
            Console.WriteLine("Area Trapézio: " + area);
        }
    }

    public class Triangulo
    {
        public double @base;
        public double altura;

        public double CalcularArea()
        {
            double area = @base * altura / 2;
            return area;
        }
    }

    public class Quadrado
    {
        public double lado;
        public double CalcularArea()
        {
            double area = Math.Pow(lado, 2);
            return area;
        }
    }

    public class Circunferencia
    {
        public double raio;
        public double CalcularArea()
        {
            double area = (Math.PI * Math.Pow(raio, 2));
            return area;
        }
    }

    public class Trapezio
    {
        public double baseMaior;
        public double baseMenor;
        public double altura;
        public double CalcularArea()
        {
            double area = (((baseMaior + baseMenor) / 2) * altura);
            return area;
        }
    }
}
