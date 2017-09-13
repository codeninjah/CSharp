using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public class Greeter
	{
		public string Welcome(int age)
		{
			if (age < 16)
			{
				return "You seem to be young";
			}
			else if (age < 18)
			{
				return "Maybe study on gymnasium?";
			}
			else
			{
				return "Maybe YH?";
			}
		}
	}
}
