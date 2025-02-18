using System;
using System.Collections.Generic;
using System.Linq;

namespace Foreach


{
	class Program
	{
		public static void Main(string[] args)
		{
		
		List<string> palavras = new List<string> { "Matatabi", "isobu", "Shukaku", "Kokuou", "Son Goku", "Hachibi", "Kurama", "Saiken", "Gyuki" };
		
		string maiorpalavra = "";
	
		foreach (string palavra in palavras)
			
		{
			if (palavra.Length > maiorpalavra.Length) 
			{
				maiorpalavra = palavra;
			}
		}
			Console.WriteLine(maiorpalavra);
	Console.ReadKey();
			
	
	
		}
	}
}
