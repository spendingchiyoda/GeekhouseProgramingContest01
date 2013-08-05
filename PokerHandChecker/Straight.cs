using System;
using System.Linq;

namespace PokerHandChecker
{
	public class Straight : CheckerBase
	{
		public Straight ()
		{
		}

		public override bool CanMakeHand (string[] cards)
		{
			// create number list
			var numCharList = 
				(from p in cards
			select p [0]).ToList ();


		    bool isAExist = false;

			// is A Exist?
			if (numCharList.Contains ('A')) {
				isAExist = true;
				numCharList.Remove ('A');
			}

			// convert to int
			// sort
			var numberList = (numCharList.Select( n => {

				int ret = 0;
				if( n == 'T' ){ ret = 10; }
				else if( n == 'J'){ ret = 11; }
				else if( n == 'Q'){ ret = 12; }
				else if( n == 'K'){ ret = 13; }
				else{ ret = Convert.ToInt32( n.ToString() ); }

				return ret;

			}).OrderByDescending( n => n))
			.ToList();

			// if A exist
			if( isAExist ){
				if( numberList[0] != 13 && numberList[0] != 5 ){
					return false;
				}
			}

			// margin check
			for(int i=0 ; i< numberList.Count -1; i++){
				if( (numberList[i] - numberList[i+1]) != 1 ){
					return false;
				}
			}


			return true;;
		}

		public override void WriteHandName(){
			Console.WriteLine ("straight");
		}


	}
}

