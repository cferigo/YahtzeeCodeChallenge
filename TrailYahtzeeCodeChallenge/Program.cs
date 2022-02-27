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

            // CF 27/2/22 creating 1000 arrays of random length containing random numbers
            // Note: if you want to run the code, set a restrcition in the array length
            
            Random rnd = new Random();
            for (int i = 1; i <= 1000; i++)
            {
                int[] numArr = new int[rnd.Next()];
                for (int j = 0; j < numArr.Length; ++j)
                    numArr[j] = rnd.Next();
                Array.Sort(numArr);

                best_score(numArr);
            }
            
            // CF 27/2/22 for testing

            /*int[] numArr = new int[] { 1, 4, 4, 4, 5, 20};
            best_score(numArr);*/
        }


        // CF 27/2/22 Function to loop through the array and find the highest score
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
    }
}
