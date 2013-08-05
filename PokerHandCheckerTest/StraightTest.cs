using System;
using NUnit.Framework;
using PokerHandChecker;

namespace PorkerHandCheckerTest
{
	[TestFixture()]
	public class StraightTest
	{
		private Straight hand = new Straight();

		[Test()]
		public void Success_1 ()
		{
			string[] cards = new string[] { "As", "Kc", "Qh", "Jd", "Ts" };

			bool result = hand.CanMakeHand (cards);

			Assert.IsTrue (result);
		}

		[Test()]
		public void Success_2 ()
		{
			string[] cards = new string[] { "5s", "4c", "Ah", "2d", "3s" };

			bool result = hand.CanMakeHand (cards);

			Assert.IsTrue (result);
		}


		[Test()]
		public void Failure_1 ()
		{
			string[] cards = new string[] { "7s", "2c", "3s", "4h", "5s" };

			var hand = new Straight();
			bool result = hand.CanMakeHand (cards);

			Assert.IsFalse (result);
		}
	}
}

