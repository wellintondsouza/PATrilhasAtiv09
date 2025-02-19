using System;

namespace ClasseCalculadora
{
    public class Calculadora
    {
        // Método para somar
        public double Somar(double a, double b)
        {
            return a + b;
        }

        // Método para subtrair
        public double Subtrair(double a, double b)
        {
            return a - b;
        }

        // Método para multiplicar
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        // Método para dividir
        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância da classe Calculadora
            Calculadora calc = new Calculadora();

            // Definindo dois números para as operações
            double num1 = 10;
            double num2 = 5;

            // Realizando as operações e exibindo os resultados
            Console.WriteLine("Soma: " + calc.Somar(num1, num2));
            Console.WriteLine("Subtração: " + calc.Subtrair(num1, num2));
            Console.WriteLine("Multiplicação: " + calc.Multiplicar(num1, num2));

            try
            {
                // Tenta realizar a divisão, com tratamento para divisão por zero
                Console.WriteLine("Divisão: " + calc.Dividir(num1, num2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Aguarda o usuário pressionar uma tecla para encerrar
            Console.ReadKey();
        }
    }
}
