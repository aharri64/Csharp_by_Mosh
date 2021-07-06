using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var random = new Random();
            for (var i = 0; i < 10; i++)
                Console.WriteLine(random.Next());
            
            PARAMETERS
            var random = new Random();
            for (var i = 0; i < 10; i++)
                Console.WriteLine(random.Next(1, 10));
            var random = new Random();
            for (var i = 0; i < 10; i++)
                Console.Write((char)random.Next(97, 122));
            Console.WriteLine((int)'a');
            */

            var random = new Random();

            const int passwordLength = 3;
            var buffer = new char[passwordLength];

            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);

            Console.WriteLine(password);



        }
    }
}
