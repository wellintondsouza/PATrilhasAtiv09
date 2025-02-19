using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Disponivel { get; private set; }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            Disponivel = true;
        }

        public bool VerificarDisponibilidade()
        {
            return Disponivel;
        }

        public bool RealizarEmprestimo()
        {
            if (Disponivel)
            {
                Disponivel = false;
                Console.WriteLine($"O livro '{Titulo}' foi emprestado com sucesso.");
                return true;
            }
            else
            {
                Console.WriteLine($"O livro '{Titulo}' não está disponível para empréstimo.");
                return false;
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {Titulo}\nAutor: {Autor}\nDisponível: {(Disponivel ? "Sim" : "Não")}");
        }
    }

    public class Biblioteca
    {
        private List<Livro> livros = new List<Livro>();

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public Livro ConsultarLivro(string titulo)
        {
            return livros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Bem-vindo à biblioteca!");
            Console.Write("Livros disponíveis:");
            Console.WriteLine("-1984"); 
            Console.WriteLine("-Dom Quixote");

            Biblioteca biblioteca = new Biblioteca();
            biblioteca.AdicionarLivro(new Livro("1984", "George Orwell"));
            biblioteca.AdicionarLivro(new Livro("Dom Quixote", "Miguel de Cervantes"));

            Console.Write("Digite o título do livro que deseja consultar: ");
            string tituloConsulta = Console.ReadLine();

            Livro livroConsultado = biblioteca.ConsultarLivro(tituloConsulta);
            if (livroConsultado != null)
            {
                livroConsultado.ExibirInformacoes();
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }
    }
}
