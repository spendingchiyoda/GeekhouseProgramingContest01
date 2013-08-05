using System;
using NUnit.Framework;
using PokerHandChecker;

namespace PorkerHandCheckerTest
{
	[TestFixture()]
	public class StraightFlushTest
	{
		private StraightFlush hand = new StraightFlush();

		[Test()]
		public void Success_1 ()
		{
			string[] cards = new string[] { "As", "Ks", "Qs", "Js", "Ts" };

			bool result = hand.CanMakeHand (cards);

			Assert.IsTrue (result);
		}

		[Test()]
		public void Success_2 ()
		{
			string[] cards = new string[] { "As", "Ts", "Qs", "Js", "Ks" };

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

