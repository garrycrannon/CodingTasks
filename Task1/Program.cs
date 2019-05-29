using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCoding1
{
    class Program
    {
        static void Main(string[] args)
        {
            //This problem was recently asked by Google.
            //Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
            //For example, given[10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
            //Bonus: Can you do this in one pass?


            List<int> numbersList = new List<int>();
            Console.WriteLine("Enter a list of numbers to choose from");
            int currentNumber;
            while (int.TryParse(Console.ReadLine(), out currentNumber) == true)
            {
                numbersList.Add(currentNumber);
            }
            Console.WriteLine("Enter a number to add up to:");
            int numberToAddTo;
            if (int.TryParse(Console.ReadLine(), out numberToAddTo) != true)
            {
                Console.WriteLine("Error!");
                Console.ReadLine();
                return;
            }

            numbersList.Sort();

            bool answerFound = false;

            foreach (int item in numbersList)
            {
                int seekedItem = numberToAddTo - item;

                if (numbersList.Contains(seekedItem))
                {

                    Console.WriteLine($"It's a match! {seekedItem} + {item}");
                    answerFound = true;
                }

            }

            if (!answerFound)
            {
                Console.WriteLine("No matches");
            }
            Console.ReadLine();
        }

        static int UniqueWays(int steps, int staircase)
        {


            return 0;
        }
    }
}
