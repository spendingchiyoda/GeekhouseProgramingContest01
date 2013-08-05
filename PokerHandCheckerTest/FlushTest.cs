using System;
using NUnit.Framework;
using PokerHandChecker;

namespace PorkerHandCheckerTest
{
	[TestFixture()]
	public class FlushTest
	{
		private Flush hand = new Flush();

		[Test()]
		public void Success_1 ()
		{
			string[] cards = new string[] { "7s", "2s", "3s", "4s", "5s" };

			bool result = hand.CanMakeHand (cards);

			Assert.IsTrue (result);
		}

		[Test()]
		public void Failure_1 ()
		{
			string[] cards = new string[] { "7s", "2c", "3s", "4h", "5s" };

			bool result = hand.CanMakeHand (cards);

			Assert.IsFalse (result);
		}
	}
}

