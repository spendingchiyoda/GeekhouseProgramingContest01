using System;
using System.Linq;

namespace PokerHandChecker
{
	public class ThreeOfAKind : CheckerBase
	{
		public ThreeOfAKind ()
		{
		}

		private FullHouse fullHouse = new FullHouse ();

		public override bool CanMakeHand (string[] cards)
		{
			if (fullHouse.CanMakeHand (cards)) {
				return false;
			}

			// number check
			var query = 
				from p in cards
					group p by p[0];


			foreach (var r in query) {
				if (r.ToList ().Count == 3) {
					return true;
				}
			}

			return false;

		}

		public override void WriteHandName(){
			Console.WriteLine ("three of a kind");
		}
	}
}

