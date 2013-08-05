using System;
using System.Linq;

namespace PokerHandChecker
{
	public class OnePair : CheckerBase
	{
		public OnePair ()
		{
		}

		public override bool CanMakeHand (string[] cards)
		{
			// number check
			var query = 
				from p in cards
					group p by p[0];

			int pairCount = 0;
			foreach (var r in query) {
				if (r.ToList ().Count == 2) {
					pairCount++;
				}

			}

			if (pairCount == 1) {
				return true;
			}

			return false;

		}

		public override void WriteHandName(){
			Console.WriteLine ("one pair");
		}
	}
}

