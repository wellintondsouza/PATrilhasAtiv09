using System;

namespace Loja
{
    public class Produto
    {
        public string Nome { get; set; }
        public double PrecoUnitario { get; set; }

        public Produto(string nome, double precoUnitario)
        {
            Nome = nome;
            PrecoUnitario = precoUnitario;
        }

        public double CalcularValorTotal(int quantidade)
        {
            if (quantidade < 0)
            {
                throw new ArgumentException("A quantidade não pode ser negativa.");
            }
            return quantidade * PrecoUnitario;
        }

        public void ExibirInformacoes(int quantidade)
        {
            Console.WriteLine($"Produto: {Nome}\nPreço Unitário: {PrecoUnitario:C}\nQuantidade: {quantidade}\nValor Total: {CalcularValorTotal(quantidade):C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("Notebook", 2500.00);

            Console.Write("Digite a quantidade desejada: ");
            if (int.TryParse(Console.ReadLine(), out int quantidade))
            {
                produto.ExibirInformacoes(quantidade);
            }
            else
            {
                Console.WriteLine("Quantidade inválida.");
            }
        }
    }
}
