using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2021, 1, 1);
            
            // To get current dateTime
            var now = DateTime.Now;

            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            Console.WriteLine();
            Console.WriteLine();
            // datetime is immutable

            // You can change them with different methods that all start with add

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            // formatting DateTime to a string
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("MMMM dd, yyyy hh:mm"));
        }
    }
}
