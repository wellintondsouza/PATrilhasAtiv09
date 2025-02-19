using System;
using System.Linq;

namespace Escola
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double[] Notas { get; set; }

        public Aluno(string nome, double[] notas)
        {
            Nome = nome;
            Notas = notas;
        }

        public double CalcularMedia()
        {
            return Notas.Average();
        }

        public string VerificarSituacao()
        {
            return CalcularMedia() >= 7.0 ? "Aprovado" : "Reprovado";
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Aluno: {Nome}\nMédia: {CalcularMedia():F2}\nSituação: {VerificarSituacao()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite as notas separadas por espaço: ");
            double[] notas = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Aluno aluno = new Aluno(nome, notas);
            aluno.ExibirInformacoes();
        }
    }
}

