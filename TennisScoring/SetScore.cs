using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TennisScoring
{
    public class SetScore
    {

      public string scoreSet;

       static SetScore()
        {
            Console.WriteLine("Enter your set score in this format 7-5 6-2: ");

           
            scoreSet = Console.ReadLine();
        }

        public SetScore(string scoreSet)
        {
            this.scoreSet = scoreSet;   
        }


    }
}
