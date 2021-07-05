using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            example 1
            int hour = 19;

            if (hour > 0 && hour < 12)
            {
                console.writeline("it's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                console.writeline("it's afternoon.");
            }
            else
            {
                console.writeline("it's evening.");
            }
            */

            
            //bool isGoldCustomer = true;

            /*
            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;
            */

            // as a conditional

            /*
            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);
            */

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's Winter");
                    break;
                case Season.Spring:
                    Console.WriteLine("It's Spring");
                    break;
                default:
                    Console.WriteLine("It's Summer");
                    break;

            }
        }
    }
}
