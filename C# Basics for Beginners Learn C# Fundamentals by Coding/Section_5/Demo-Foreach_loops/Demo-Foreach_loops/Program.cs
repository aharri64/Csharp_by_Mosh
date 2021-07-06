using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Foreach_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop
            /*
            var name = "John Smith";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            //FOREACH LOOP
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            */

            var numbers = new int[] {1, 2, 3, 4};
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
