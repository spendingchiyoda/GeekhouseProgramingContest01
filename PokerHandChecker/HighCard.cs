using System;

namespace PokerHandChecker
{
	public class HighCard : CheckerBase
	{
		public HighCard ()
		{
		}

		public override bool CanMakeHand (string[] cards)
		{
			throw new NotImplementedException ();
		}

		public override void WriteHandName(){
			Console.WriteLine ("straight flash");
		}
	}
}

