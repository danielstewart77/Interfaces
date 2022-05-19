using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		public static void Main()
		{
			Player p1 = new();
			p1.Name = "Daniel";

			Console.WriteLine($"Player name: {p1.Name} id: {p1.Id}");
			Console.ReadKey();
		}
	}
}

