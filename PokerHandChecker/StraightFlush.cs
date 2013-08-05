using System;
using System.Linq;

namespace PokerHandChecker
{
	public class StraightFlush  : CheckerBase
	{
		public StraightFlush ()
		{
		}

		private Straight straight = new Straight ();
		private Flush flush = new Flush();

		public override bool CanMakeHand (string[] cards)
		{
			// suits check
			if (!flush.CanMakeHand (cards)) {
				return false;
			}

			// number check
			if( !straight.CanMakeHand(cards) ){
				return false;
			}

			return true;

		}

		public override void WriteHandName(){
			Console.WriteLine ("straight flash");
		}
	}
}

