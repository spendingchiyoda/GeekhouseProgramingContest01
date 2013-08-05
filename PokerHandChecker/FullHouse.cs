using System;
using System.Linq;

namespace PokerHandChecker
{
	public class FullHouse : CheckerBase
	{
		public FullHouse ()
		{
		}

		public override bool CanMakeHand (string[] cards)
		{
			// number check
			var query = 
				from p in cards
					group p by p[0];

			bool isThreecard = false;
			bool isOnpair = false;


			foreach (var r in query) {
				if (r.ToList ().Count == 3) {
					isThreecard = true;
				}

				if (r.ToList ().Count == 2) {
					isOnpair = true;
				}

				if (isThreecard && isOnpair) {
					return true;
				}
			}

			return false;
		}

		public override void WriteHandName(){
			Console.WriteLine ("full house");
		}
	}
}

