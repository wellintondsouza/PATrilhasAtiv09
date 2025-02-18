using System;
using System.Collections.Generic;
using System.Linq;

namespace Foreach


{
	class Program
	{
		public static void Main(string[] args)
		{
		
		List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };
		
		int Maiornumero = numeros.Max();
			
			{
			Console.WriteLine(Maiornumero);
			}
		 Console.ReadKey();
		}
	}
}
