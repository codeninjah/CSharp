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
			Assert.AreEqual(600, actual2);
		}
	}
}
