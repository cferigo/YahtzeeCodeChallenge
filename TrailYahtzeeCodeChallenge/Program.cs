using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailYahtzeeCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            // initiallising the array and ranomd number
            //int[] numArr = new int[] { 10, 10, 9, 9, 9, 8, 6, 6, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            Random rnd = new Random();
            for (int i = 1; i <= 1000; i++)
            {
                int[] numArr = new int[rnd.Next(1000)];
                // creating the array of random numbers
                for (int j = 0; j < numArr.Length; ++j)
                    numArr[j] = rnd.Next();
                // sorting the array into descending order and getting the highest number
                Array.Sort(numArr);
                Array.Reverse(numArr);

                best_score(numArr);
            }
        }

        static void best_score(int[] numArr)
        {
            int highestScore = 0;
            int currentScore = 0;
            int currentNumber = 0;

            for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] != currentNumber)
                {
                    currentScore = numArr[i];
                    currentNumber = numArr[i];

                    if (currentScore > highestScore)
                    {
                        highestScore = currentScore;
                    }
                }
                else if (numArr[i] == currentNumber)
                {
                    currentScore += numArr[i];

                    if (currentScore > highestScore)
                    {
                        highestScore = currentScore;
                    }
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", numArr));
            Console.WriteLine("Best Score: " + highestScore);
        }

        public static int[] generate_random_array()
        {
            Random rnd = new Random();
            int[] numArr = new int[rnd.Next(1,100)];
            // creating the array of random numbers
            for (int i = 0; i < numArr.Length; ++i)
                numArr[i] = rnd.Next(1, 11);
            // sorting the array into descending order and getting the highest number
            Array.Sort(numArr);
            Array.Reverse(numArr);
            return numArr;
        }
    }
}
