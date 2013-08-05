using System;
using System.Linq;

namespace PokerHandChecker
{
	public class TwoPair : CheckerBase
	{
		public TwoPair ()
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

			if (pairCount == 2) {
				return true;
			}

			return false;
		
		}

		public override void WriteHandName(){
			Console.WriteLine ("two pair");
		}
	}
}

