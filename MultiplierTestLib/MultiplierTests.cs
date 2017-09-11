using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplierTestLib
{
	[TestClass]
	public class MultiplierTests
	{
		[TestMethod]
		public void Simple()
		{
			// Arrange - skapar obj man vill testa
			MultiplierLib.Multiplier myMultiplier = new MultiplierLib.Multiplier();

			// Act - utför det man vill testa
			var actual = myMultiplier.Simple(10, 20);

			// Assert - kontrollerar att utfallet stämmer med verkligheten
			Assert.AreEqual(200, actual);


		}

		[TestMethod]
		public void While()
		{
			MultiplierLib.Multiplier myMultiplier2 = new MultiplierLib.Multiplier();
			var actual2 = myMultiplier2.While(20, 50);
			Assert.AreEqual(1000, actual2);
		}

		[TestMethod]
		public void For()
		{
			MultiplierLib.Multiplier myMultiplier3 = new MultiplierLib.Multiplier();
			var actual3 = myMultiplier3.UsingFor(20, 60);
			Assert.AreEqual(1200, actual3);
		}
	}
}
