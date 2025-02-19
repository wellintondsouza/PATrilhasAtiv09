using System;
using System.Collections.Generic;
using System.Linq;

namespace Foreach
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Initialize the list with some numbers
            List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };

            // Check if the list is not empty
            if (numeros.Count > 0)
            {
                // Calculate the sum of the numbers
                int sum = 0;
                foreach (int numero in numeros)
                {
                    sum += numero;
                }

                // Calculate the average
                double media = (double)sum / numeros.Count;

                // Output the average
                Console.WriteLine("A média é: " + media);
            }
            else
            {
                Console.WriteLine("A lista está vazia.");
            }

            Console.ReadKey();
        }
    }
}
