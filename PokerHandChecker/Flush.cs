using System;
using System.Linq;

namespace PokerHandChecker
{
	public class Flush : CheckerBase
	{
		public Flush ()
		{
		}

		public override bool CanMakeHand (string[] cards)
		{
			// suits check
			var suitsList = 
				(from p in cards
				 group p by p [1]).ToList();

			if( suitsList.Count != 1 ){ return false; }

			return true;
		}

		public override void WriteHandName(){
			Console.WriteLine ("flush");
		}
	}
}

