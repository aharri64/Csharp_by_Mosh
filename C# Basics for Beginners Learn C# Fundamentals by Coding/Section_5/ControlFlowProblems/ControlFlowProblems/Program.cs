using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFlowProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1- 
            Write a program to count how many numbers 
            between 1 and 100 are divisible by 3 with no remainder. 
            Display the count on the console.
            */

            /* Answer
            var count = 0;
            for (var i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }

            Console.WriteLine("There are {0} numbers in between 0 and 100 that are divisible by 3", count);
            */

            /*
            2- 
            Write a program and continuously ask the user to enter a number or "ok" to exit. 
            Calculate the sum of all the previously entered numbers and display it on the console.
            */

            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                {
                    break;
                }
                else
                {
                    sum += Convert.ToInt32(input);
                }
            }
            Console.WriteLine("Sum of all numbers is: " + sum);
        }
    }
}
