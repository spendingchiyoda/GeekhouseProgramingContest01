using System;
using System.Linq;

namespace PokerHandChecker
{
	public class FourOfAKind  : CheckerBase
	{
		public FourOfAKind ()
		{
		}

		public override bool CanMakeHand (string[] cards)
		{
			// number check
			var query = 
				from p in cards
				 group p by p[0];

			foreach (var r in query) {
				if (r.ToList ().Count == 4) {
					return true;
				}
			}

			return false;
		}

		public override void WriteHandName(){
			Console.WriteLine ("four of a kind");
		}
	}
}

