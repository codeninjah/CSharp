using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
	public class ListHandler
	{
		public List<string> List = new List<string>();

		public void AddFiveStrings()
		{
			List.Add("Alex");
			List.Add("Mikael");
			List.Add("Mostafa");
			List.Add("Mostafa");
			List.Add("Gentrit");
		}

		public void RemoveThirdString()
		{
			List.RemoveAt(3);
		}

		public void Sort()
		{
			List.Sort();
		}
	}
}