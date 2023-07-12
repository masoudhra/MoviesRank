using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies_Rank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] movies = new string[3] { "Inspection", "Taken 1", "Rain Man" };
            List<int> ranks = new List<int>();
            for (int i = 0; i < movies.Length; i++)
            {
                string text = ("Please insert your rank (1-10) for the movies: " + movies[i] + "i");
                Console.WriteLine(text);
                int rank = Convert.ToInt32(Console.ReadLine());
                ranks.Add(rank);

            }
            double average = CalculateAverage(ranks);
            Console.WriteLine("The average Rank is:");
            Console.WriteLine(average);
            Console.ReadKey();
        }

        public static double CalculateAverage(List<int> userRanks)
        {
            int sum = 0;
            for (int i = 0; i < userRanks.Count; i++) 
                {
                sum += userRanks[i];

                }
            double avg = sum / userRanks.Count;
            return avg;
        }
    }
}
