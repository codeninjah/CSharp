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
			Assert.AreEqual(400, actual);


		}
	}
}
