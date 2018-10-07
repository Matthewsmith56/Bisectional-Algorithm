using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection_Algorithm
{
    public class ComputerGuessClass
    {
        List<int> numbers = Enumerable.Range(1, 101).ToList();

        public static void ComputerPlay()
        {
            var random = new Random();
            int ranNum2 = random.Next(1, 101);
            Console.WriteLine("Enter a number between 1 and 100");
            int userNum = Convert.ToInt32(Console.ReadLine());

            bool numFound = false;
            while (numFound == false)
            {
                Console.WriteLine("Is {0} your number. \n1 - Yes " +
                                                      "\n2 - Too high " +
                                                      "\n3 - Too Low", ranNum2);
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("I guessed right, Kneel before your machine overlords");
                }
                else if (Console.ReadLine() == "2")
                {

                }
                else if (Console.ReadLine() == "3")
                {
                    
                }
            }
        }
    }
}
