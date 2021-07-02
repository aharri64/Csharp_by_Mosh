using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Amir";
            var lastName = "Harrison";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My Name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Jeremy"};
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);


            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);
            //or
            var text2 = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text2);
        }
    }
}
