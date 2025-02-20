using System;

namespace Geometria
{
    public class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double CalcularArea()
        {
            return Largura * Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Retângulo:\nLargura: {Largura}\nAltura: {Altura}\nÁrea: {CalcularArea()}\nPerímetro: {CalcularPerimetro()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a largura do retângulo: ");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine());

            Retangulo retangulo = new Retangulo(largura, altura);
            retangulo.ExibirInformacoes();
        }
    }
}
