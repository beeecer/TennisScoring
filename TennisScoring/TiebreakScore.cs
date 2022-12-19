using System;
using System.Collections.Generic;
using System.Text;

namespace TennisScoring
{
    internal class TiebreakScore
    {

        public string tiebreakScore;

        public TiebreakScore()
        {
            Console.WriteLine("Enter your tiebreak in this format 10-7: ");
            tiebreakScore = Console.ReadLine();
        }

        public TiebreakScore(string tiebreakScore)
        {
            this.tiebreakScore = tiebreakScore;
        }


    }
}
