using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection_Algorithm
{
    public class HumanPlayClass
    {
        public static void HumanPlay()
        {
            var random = new Random();
            int ranNum = random.Next(1, 1001);
            bool numFound2 = false;

            Console.WriteLine("Choose a number between 1 and 1000");
            int selNum = Convert.ToInt32(Console.ReadLine());

            while (numFound2 == false)
            {
                if (ranNum == selNum)
                {
                    Console.WriteLine("Correct, The number is {0}", ranNum);
                    numFound2 = true;
                }
                else if (selNum > ranNum)
                {
                    Console.WriteLine("Too high, enter a new number");
                }
                else if (selNum < ranNum)
                {
                    Console.WriteLine("Too low, enter a new number");
                }
                selNum = Convert.ToInt32(Console.ReadLine());
            }
            
        }
    }
}
