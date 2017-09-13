using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public class StoryTeller
	{
		public string TellStory(string nameOfChild, int ageOfChild, bool willBeScary)
		{

			var tal = "";
			if (ageOfChild < 5 && willBeScary)
				throw new InvalidOperationException($"Unga barn ska inte bli skrämda");
			if (ageOfChild < 7)
				tal = $"Lyssna nu {nameOfChild}. Det var en gång en prinsessa.";
			if (ageOfChild >= 7)
				tal = $"Hallå {nameOfChild}. En gång fanns en kille";
			if (willBeScary)
				tal += $" som egentligen var en varulv";
			if (!willBeScary)
				tal += $" som tyckte om att dansa";

			return tal;


		}
	}
}
