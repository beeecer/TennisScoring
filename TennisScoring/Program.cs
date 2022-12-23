using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace TennisScoring
{
    internal class Program : INum
    {
        public void Main(string[] args)
        {
            TiebreakScore();
            SetScore();
            SetScore2();
            TotalScore();
        }

        public static void SetScore()
        {
            Console.WriteLine("Enter your first set score in this format 7-5: ");
            set1 = Console.ReadLine();
        }

        private static void SetScore2()
        {
            Console.WriteLine("Enter your second set score in the same format: ");
            set2 = Console.ReadLine();
        }


        public static void TiebreakScore()
        {
            Console.WriteLine("Enter your tiebreak in this format 10-7: ");
            tiebreakScore = Console.ReadLine();
        }

        public static string set1;
        public static string set2;
        public static string tiebreakScore;

        public async void TotalScore()
        {
            Console.WriteLine("Your current first set score is: " + set1 + " and your second set score is: " + set2);

            await Task.Delay(4000);

            Console.WriteLine("and the tiebreak score is:  "+ tiebreakScore);
        }
    }
}
