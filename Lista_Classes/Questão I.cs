using System;
using System.Collections.Generic;

namespace Contatos
{
    public class Agenda
    {
        private List<Contato> contatos = new List<Contato>();

        public void AdicionarContato(string nome, string telefone)
        {
            contatos.Add(new Contato(nome, telefone));
        }

        public void RemoverContato(string nome)
        {
            contatos.RemoveAll(c => c.Nome == nome);
        }

        public void BuscarContato(string nome)
        {
            foreach (var contato in contatos)
            {
                if (contato.Nome.Contains(nome))
                {
                    Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}");
                }
            }
        }
    }

    public class Contato
    {
        public string Nome { get; }
        public string Telefone { get; }

        public Contato(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }

    class Program
    {
        static void Main()
        {
            Agenda agenda = new Agenda();
            agenda.AdicionarContato("João", "1234-5678");
            agenda.AdicionarContato("Maria", "8765-4321");
            agenda.AdicionarContato("Carlos", "9876-5432");
            agenda.AdicionarContato("Ana", "4321-8765");
            agenda.AdicionarContato("Pedro", "5678-1234");
            agenda.AdicionarContato("Lucas", "3456-7890");
            agenda.AdicionarContato("Fernanda", "6543-2109");
            agenda.AdicionarContato("Beatriz", "7890-4321");
            agenda.AdicionarContato("Ricardo", "2109-6543");
            agenda.AdicionarContato("Juliana", "8765-0987");
            agenda.AdicionarContato("Marcos", "3456-1234");
            agenda.AdicionarContato("Tatiane", "9087-6543");


            Console.Write("Digite o nome para buscar: ");
            agenda.BuscarContato(Console.ReadLine());
        }
    }
}
