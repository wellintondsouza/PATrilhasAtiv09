using System;
using System.Collections.Generic;


namespace Foreach
{
	class Program
	{
		public static void Main(string[] args)
		{
			List<string> nomes = new List<string> {"Ana", "Brian", "Carlos"};
			
			foreach (string nome in nomes)
			{
				Console.WriteLine(nome);
			}
			Console.ReadKey();
		}
	}
}
