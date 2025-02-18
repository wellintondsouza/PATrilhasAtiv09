using System;

namespace Foreach
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] numeros = {10, 20, 30, 40, 50};
			
			foreach (int numero in numeros)
			{
			Console.WriteLine(numero);
			}
			Console.ReadKey();
		
			}
	}
}
