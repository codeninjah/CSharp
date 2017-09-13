using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("How old are you?");
			var age = int.Parse(Console.ReadLine());
			Greeter greeter = new Greeter();
			string message = greeter.Welcome(age);

			

		}
	}

	
}
