using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;


namespace MultiplierTestLib
{
	[TestClass]
	public class StoryTellerTests
	{
		[TestMethod]
		public void TestMethod1()
		{

			StoryTeller Test1 = new StoryTeller();
			var test = Test1.TellStory("Alexandru", 6, false);
			Assert.AreEqual($"Lyssna nu Alexandru. Det var en gång en prinsessa. som tyckte om att dansa", test);

		}

		[TestMethod]
		public void TestMethod2()
		{
			StoryTeller Test2 = new StoryTeller();
			var test2 = Test2.TellStory("Matts", 7, true);
			Assert.AreEqual($"Hallå Matts. En gång fanns en kille som egentligen var en varulv", test2);
		}

		[TestMethod]
		public void TestMethod3()
		{
			StoryTeller Test3 = new StoryTeller();
			var test3 = Test3.TellStory("Robin", 4, true);
			Assert.AreEqual($"Unga barn ska inte bli skrämda", test3);
		}


	}
}
