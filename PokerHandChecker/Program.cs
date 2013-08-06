using System;

namespace PokerHandChecker
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			if (args.Length != 5) { 
				Console.WriteLine ("error: wrong args length.");
			}

			string handsName = null;
			CheckerBase[] checkers = new CheckerBase[]{ 
				new StraightFlush(),
				new FourOfAKind(),
				new FullHouse(),
				new Flush(),
				new Straight(),
				new ThreeOfAKind(),
				new TwoPair(),
				new OnePair()
			};

			foreach (var ck in checkers) {
				if (ck.CanMakeHand (args)) {
				    ck.WriteHandName ();
					return;

				}

			}

			// High card
			handsName = "high card";

			Console.WriteLine (handsName);
		}
	}
}
