using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Amir Harrison ";
            // Trim
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            // ToUpper()
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            // Break up into first name and last name
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName + "\n"+ "Last Name: " + lastName);
            // Or Split Method
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            // Replace
            Console.WriteLine(fullName.Replace("Amir", "Scott"));

            if (String.IsNullOrEmpty(null))
                Console.WriteLine("1. Invalid");

            if (String.IsNullOrEmpty(""))
                Console.WriteLine("2. Invalid");
 
            if (String.IsNullOrEmpty(" "))
                Console.WriteLine("3. Invalid"); //Does not work

            if (String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("4. Invalid"); //Have to add the trim method
            
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("5. Invalid"); //MICROSOFT INTRODUCED A NEW METHOD TO FIX THIS

            // Convert Numbers To Strings
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine("Age using convert method: " + age);

            float price = 29.95f;
            Console.WriteLine("Price Example using convert: " + price.ToString("C"));

        }
    }
}
