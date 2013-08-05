using System;
using NUnit.Framework;
using PokerHandChecker;

namespace PorkerHandCheckerTest
{
	[TestFixture()]
	public class TwoPairTest
	{
		private TwoPair hand = new TwoPair();

		[Test()]
		public void Success_1 ()
		{
			string[] cards = new string[] { "Js", "Jh", "3c", "2c", "3s" };

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

