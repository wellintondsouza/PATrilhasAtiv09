using System;

namespace Geometria
{
    public class Triangulo
    {
        public double Lado1 { get; private set; }
        public double Lado2 { get; private set; }
        public double Lado3 { get; private set; }

        public Triangulo(double lado1, double lado2, double lado3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public string Classificar()
        {
            if (Lado1 == Lado2 && Lado2 == Lado3)
                return "Equilátero";
            else if (Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3)
                return "Isósceles";
            else
                return "Escaleno";
        }

        public bool EhTrianguloValido()
        {
            return (Lado1 + Lado2 > Lado3) && (Lado1 + Lado3 > Lado2) && (Lado2 + Lado3 > Lado1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro lado do triângulo: ");
            double lado1 = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o segundo lado do triângulo: ");
            double lado2 = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o terceiro lado do triângulo: ");
            double lado3 = double.Parse(Console.ReadLine());
            
            Triangulo triangulo = new Triangulo(lado1, lado2, lado3);
            
            if (triangulo.EhTrianguloValido())
            {
                Console.WriteLine("O triângulo é: " + triangulo.Classificar());
            }
            else
            {
                Console.WriteLine("Valores inválidos.");
            }
        }
    }
}
