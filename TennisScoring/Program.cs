using System;
using System.Security.Cryptography.X509Certificates;

namespace TennisScoring
{
    internal class Program : INum
    {
         void Main(string[] args)
        {
            TiebreakScore();
            SetScore();
            SetScore2();
            TotalScore();
        }

        private static void SetScore()
        {
            Console.WriteLine("Enter your first set score in this format 7-5: ");
            set1 = Console.ReadLine();
        }

        private static void SetScore2()
        {
            Console.WriteLine("Enter your second set score in the same format: ");
            set2 = Console.ReadLine();
        }


        private static void TiebreakScore()
        {
            Console.WriteLine("Enter your tiebreak in this format 10-7: ");
            tiebreakScore = Console.ReadLine();
        }

        private static string set1;
        private static string set2;
        private static string tiebreakScore;

        public void TotalScore()
        {
            Console.WriteLine("Your current first set score is: " + tiebreakScore + " and your second set score is: " 
                              + set2 + " and the tiebreak score is: " + tiebreakScore);
        }
    }
}
