using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Directory_and_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            Directory.CreateDirectory(path);

            var files = Directory.GetFiles(@"d:\Projects\Udemy\Csharp_by_Mosh", "*.md", SearchOption.AllDirectories);
            //foreach (var file in files)
            //    Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"d:\Projects\Udemy\Csharp_by_Mosh", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...Path");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
