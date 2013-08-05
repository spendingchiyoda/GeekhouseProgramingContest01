using System;
using NUnit.Framework;
using PokerHandChecker;

namespace PokerHandCheckerTest
{
	[TestFixture()]
	public class FourOfAKindTest
	{
		private FourOfAKind hand = new FourOfAKind();

		[Test()]
		public void Suucess_1(){
			string[] cards = new string[] { "1s", "1c", "1d", "1h", "5s" };

			bool result = hand.CanMakeHand (cards);

			Assert.IsTrue (result);
		}

		[Test()]
		public void Suucess_2(){
			string[] cards = new string[] { "5s", "5c", "5d", "1h", "5s" };

			bool result = hand.CanMakeHand (cards);

			Assert.IsTrue (result);
		}

		[Test()]
		public void Failure_1(){
			string[] cards = new string[] { "3s", "1c", "1d", "1h", "5s" };

			bool result = hand.CanMakeHand (cards);

			Assert.IsFalse(result);
		}

		[Test()]
		public void Failure_2(){
			string[] cards = new string[] { "3s", "2c", "1d", "1h", "5s" };

			bool result = hand.CanMakeHand (cards);

			Assert.IsFalse(result);
		}


	}
}

