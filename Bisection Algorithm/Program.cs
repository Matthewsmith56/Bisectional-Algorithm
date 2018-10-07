using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection_Algorithm
{
    public class Program
    {
        static List<int> numbers = new List<int>(){0,1,2,3,4,5,6,7,8,9,10};

        public static void Main(string[] args)
        {
            Console.WriteLine("Choose an option \n1 - Computer Guesses " +
                                               "\n2 - You Guess" +
                                               "\n3 - Computer Guess");
            string input = Console.ReadLine();

            if (input == "1")
            {
                SplitString();
            }
            else if (input == "2")
            {
                HumanPlayClass.HumanPlay();
            }
            else if (input == "3")
            {
                ComputerGuessClass.ComputerPlay();
            }
        }
        public static void SplitString()
        {
            Console.WriteLine("Choose a number between one and ten?");
            int userInput = Convert.ToInt32(Console.ReadLine());

            bool numFound = false;
            while (numFound == false)
            {
                if (userInput == numbers[numbers.Count / 2])
                {
                    Console.WriteLine("your number is {0}", numbers[numbers.Count / 2]);
                    numFound = true;
                }
                else if (userInput < numbers[numbers.Count / 2])
                {
                    numbers.Reverse();
                    numbers.RemoveRange(0, numbers.Count / 2);
                    Console.WriteLine("Removing all numbers from top half of list");
                    numbers.Reverse();
                }
                else if (userInput > numbers[numbers.Count / 2])
                {
                    numbers.RemoveRange(0, numbers.Count / 2);
                    Console.WriteLine("Removing all numbers from bottom half of list");
                }
            }
        }
    }
}
