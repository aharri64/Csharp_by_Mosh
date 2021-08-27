using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Write a program and ask the user to enter a number.
            //The number should be between 1 to 10.
            //If the user enters a valid number, display "Valid" on the console.
            //Otherwise, display "Invalid".
            //(This logic is used a lot in applications where values entered into input boxes need to be validated.)

            //Pick a number between 1 and 10
            Console.Write("Please Enter a number between 1 and 10: ");
            var input = Console.ReadLine();
            var numberChosen = Convert.ToInt32(input);

            if (numberChosen >= 1 && numberChosen <= 10)
            {
                var chosenNumberValid = $"You have chosen {numberChosen} \nThis number is valid";
                Console.WriteLine(chosenNumberValid);
            }
            else
            {
                Console.WriteLine("This number is invalid");
            }

            /*
            My answer
            int numberChosen = 16;

            if (numberChosen > 0 && numberChosen <= 10)
            {
                var chosenNumberStatement = string.Format("You have chosen {0}", numberChosen);
                Console.WriteLine(chosenNumberStatement);
            }
            else
            {
                Console.WriteLine("You have chosen an invalid number");
            }
            */

            //2
            //Write a program which takes two numbers from the console and displays the maximum of the two.

            Console.Write("Please enter the first number: ");
            var firstInput = Console.ReadLine();
            Console.Write("Please enter the second number: ");
            var secondInput = Console.ReadLine();
            var firstNumber = Convert.ToInt32(firstInput);
            var secondNumber = Convert.ToInt32(secondInput);

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"{firstNumber} is bigger than {secondNumber}");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine($"{firstNumber} is smaller than {secondNumber}");
            }
            else
            {
                Console.WriteLine("They are the same number");
            }

            /*
            My Answer
            var numberOne = 6;
            var numberTwo = 4;

            if (numberOne > numberTwo)
            {
                Console.WriteLine(string.Format("Number One is {0} and it is larger than Number Two which is {1}", numberOne, numberTwo));
            }
            else
            {
                Console.WriteLine(string.Format("Number One is {0} and it is smaller than Number Two which is {1}", numberOne, numberTwo));
            }
            */

            //3
            //Write a program and ask the user to enter the width and height of an image.
            //Then tell if the image is landscape or portrait.

            /*
            My Answer 
            var Width = 4;
            var Height = 3;

            if (Width > Height)
            {
                Console.WriteLine("This picture is a Landscape");
            }
            else
            {
                Console.WriteLine("This picture is a Portrait");   
            }
            */

            //4
            //Your job is to write a program for a speed camera.
            //For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
            //Write a program that asks the user to enter the speed limit.
            //Once set, the program asks for the speed of a car.
            //If the user enters a value less than the speed limit, program should display Ok on the console.
            //If the value is above the speed limit, the program should calculate the number of demerit points.
            //For every 5km / hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
            //If the number of demerit points is above 12, the program should display License Suspended.

            /*
            My Answer
            var speedOfCar = 56;
            var speedLimit = 45;

            if (speedOfCar <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else if (speedOfCar >= speedLimit + 5 && speedOfCar < speedLimit + 10)
            {
                Console.WriteLine("You have received 1 demerit");
            }
            else if (speedOfCar >= speedLimit + 10 && speedOfCar < speedLimit + 15)
            {
                Console.WriteLine("You have received 2 demerits");
            }
            */
        }
    }
}
