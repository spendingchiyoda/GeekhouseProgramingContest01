using System;

namespace PokerHandChecker
{
	public abstract class CheckerBase
	{
		public abstract bool CanMakeHand (string[] cards);
		public abstract void WriteHandName ();

	}
}

