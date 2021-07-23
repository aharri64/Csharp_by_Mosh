using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Projects\Udemy\Csharp_by_Mosh";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("extension: " + Path.GetExtension(path));
        }
    }
}
