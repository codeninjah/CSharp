using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;

namespace GreeterTests
{
	[TestClass]
	public class GreeterTest
	{
		[TestMethod]
		public void WhenUnder15()
		{
			var sut = new Greeter();
			var message = sut.Welcome(20);
			Assert.AreEqual("Maybe YH?", message);
		}
	}
}
