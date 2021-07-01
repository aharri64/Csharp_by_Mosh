
using System;

namespace Demo_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var family = new string[4] {"Amir", "Stormy", "Charlee", "Rigby"};

            Console.WriteLine(family[0]);
            Console.WriteLine(family[1]);
            Console.WriteLine(family[2]);
            Console.WriteLine(family[3]);
        }
    }
}
