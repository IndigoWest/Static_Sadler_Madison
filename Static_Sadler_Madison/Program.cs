// System namespace needed to use console class
using System;

// My collection of classes for this project
namespace Static_Sadler_Madison
{
    // Main class for Program.cs
    class Program
    {
        // The Main method is executed when the application starts
        static void Main(string[] args)
        {
            // Prints addition calculation to the console and assigns 13 to x and 92 to y
            Console.WriteLine(Calculate.Add(13, 92));
            // Prints subtraction calculation to the console and assigns 59 to x and 21 to y
            Console.WriteLine(Calculate.Sub(59, 21));
            // Prints multiplication calculation to the console and assigns 2 to x and 9 to y
            Console.WriteLine(Calculate.Mult(2, 9));
            // Prints division calculation to the console and assigns 28 to x and 4 to y
            Console.WriteLine(Calculate.Div(28, 4));

            // Prints addition calculation to the console and assigns 28.49f to x and 29.59f to y
            Console.WriteLine(Calculate.Add(28.49f, 29.59f));
            // Prints subtraction calculation to the console and assigns 10.47f to x and 2.43f to y
            Console.WriteLine(Calculate.Sub(10.47f, 2.43f));
            // Prints multiplication calculation to the console and assigns 19.39f to x and 29.38f to y
            Console.WriteLine(Calculate.Mult(19.39f, 29.38f));
            // Prints division calculation to the console and assigns 92.57f to x and 29.32f to y
            Console.WriteLine(Calculate.Div(92.57f, 29.32f));
        }
    }
}
