using System;
using System.Collections.Generic;

namespace BancoApp
{
    public class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta)
        {
            NumeroConta = numeroConta;
            Saldo = 0.0;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine("Depósito de " + valor + " realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
        }

        public bool Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine("Saque de " + valor + " realizado com sucesso.");
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor inválido.");
                return false;
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo da conta " + NumeroConta + ": " + Saldo.ToString("C"));
        }
    }

    public class Banco
    {
        private List<ContaBancaria> contas = new List<ContaBancaria>();

        public void AbrirConta(int numeroConta)
        {
            var conta = new ContaBancaria(numeroConta);
            contas.Add(conta);
            Console.WriteLine("Conta de número " + numeroConta + " aberta com sucesso.");
        }

        public void FecharConta(int numeroConta)
        {
            var conta = contas.Find(c => c.NumeroConta == numeroConta);
            if (conta != null)
            {
                contas.Remove(conta);
                Console.WriteLine("Conta de número " + numeroConta + " fechada com sucesso.");
            }
            else
            {
                Console.WriteLine("Conta de número " + numeroConta + " não encontrada.");
            }
        }

        public ContaBancaria EncontrarConta(int numeroConta)
        {
            return contas.Find(c => c.NumeroConta == numeroConta);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.AbrirConta(1001);

            var conta = banco.EncontrarConta(1001);
            if (conta == null)
            {
                Console.WriteLine("Conta não encontrada.");
                return;
            }

            Console.Write("Digite o valor a ser depositado: ");
            string inputDeposito = Console.ReadLine();
            double valorDeposito;
            if (double.TryParse(inputDeposito, out valorDeposito) && valorDeposito > 0)
            {
                conta.Depositar(valorDeposito);
            }
            else
            {
                Console.WriteLine("Valor inválido para depósito ou valor deve ser maior que 0.");
            }

            conta.ExibirSaldo();

            double valorSaque;
            do
            {
                Console.Write("Digite o valor a ser sacado: ");
                string inputSaque = Console.ReadLine();
                if (double.TryParse(inputSaque, out valorSaque) && valorSaque > 0)
                {
                    if (conta.Sacar(valorSaque))
                        break;
                }
                else
                {
                    Console.WriteLine("Valor inválido para saque ou valor deve ser maior que 0.");
                }
            } while (true);

            conta.ExibirSaldo();
            Console.ReadKey();
        }
    }
}
