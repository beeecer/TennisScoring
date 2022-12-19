using System;
using System.Security.Cryptography.X509Certificates;

namespace TennisScoring
{
    internal class Program : INum
    {
        static void Main(string[] args)
        {
            TiebreakScore();
            SetScore();

        }

        private static void SetScore()
        {
           
        }

        private static void TiebreakScore()
        {

        }

        SetScore set1 = new SetScore();
        TiebreakScore tiebreak = new TiebreakScore();

        public void TotalScore()
        {
            Console.WriteLine("Your current set score is: " + set1);
        }
    }
}
