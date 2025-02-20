using System;
using System.Collections.Generic;

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }
}

public class CarrinhoDeCompras
{
    private List<Produto> produtos;

    public CarrinhoDeCompras()
    {
        produtos = new List<Produto>();
    }

    // Adicionar produto ao carrinho
    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    }

    // Calcular o valor total da compra
    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var produto in produtos)
        {
            total += produto.Preco;
        }
        return total;
    }

    // Exibir os itens do carrinho
    public void ExibirItens()
    {
        if (produtos.Count == 0)
        {
            Console.WriteLine("O carrinho está vazio.");
            return;
        }

        Console.WriteLine("Itens no carrinho:");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"- {produto.Nome}: R${produto.Preco:F2}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Lista de produtos disponíveis
        List<Produto> listaDeProdutos = new List<Produto>
        {
            new Produto("Camiseta", 49.90m),
            new Produto("Calça Jeans", 129.90m),
            new Produto("Tênis", 199.90m),
            new Produto("Jaqueta", 159.90m),
            new Produto("Boné", 39.90m)
        };

        CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

        // Menu de interação
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Produtos disponíveis:");
            for (int i = 0; i < listaDeProdutos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listaDeProdutos[i].Nome} - R${listaDeProdutos[i].Preco:F2}");
            }

            Console.WriteLine("\nEscolha um produto para adicionar ao carrinho (digite o número ou 0 para finalizar):");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int escolha) && escolha >= 0 && escolha <= listaDeProdutos.Count)
            {
                if (escolha == 0)
                {
                    continuar = false;
                }
                else
                {
                    Produto produtoEscolhido = listaDeProdutos[escolha - 1];
                    carrinho.AdicionarProduto(produtoEscolhido);
                    Console.WriteLine($"Produto '{produtoEscolhido.Nome}' adicionado ao carrinho!\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Escolha inválida. Tente novamente.");
                Console.ReadKey();
            }
        }

        // Exibindo os itens do carrinho e o total
        Console.Clear();
        carrinho.ExibirItens();
        decimal total = carrinho.CalcularTotal();
        Console.WriteLine($"\nValor total da compra: R${total:F2}");
    }
}
