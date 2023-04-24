// System namespace needed to use Console class
using System;
// System.Collections.Generic namespace needed to use Console class
using System.Collections.Generic;
// System.Text namespace needed to use Console class
using System.Text;

// My collection of classes for this project
namespace Static_Sadler_Madison
{
    // Main class for Calculate.cs
    class Calculate
    {
        // The Main method is executed when the application starts
        // Initializes a public static float called result and assigns the value 0.0f
        public static float result = 0.0f;

        // Creates static Calculate()
        static Calculate()
        {
            // Shows result is 0.0f
            result = 0.0f;
        }
        // Adds ints x and y
        public static int Add(int x, int y)
        {
            // Returns x + y
            return x + y;
        }

        // Subtracts ints x and y
        public static int Sub(int x, int y)
        {
            // Returns x - y
            return x - y;
        }

        // Multiplies ints x and y
        public static int Mult(int x, int y)
        {
            // Returns x * y
            return x * y;
        }

        // Divides ints x and y
        public static int Div(int x, int y)
        {
            // Returns x / y
            return x / y;
        }

        // Adds floats x and y
        public static float Add(float x, float y)
        {
            // Returns x + y
            return x + y;
        }

        // Subtracts floats x and y
        public static float Sub(float x, float y)
        {
            // Returns x - y
            return x - y;
        }

        // Multiplies floats x and y
        public static float Mult(float x, float y)
        {
            // Returns x * y
            return x * y;
        }

        // Divides floats x and y
        public static float Div(float x, float y)
        {
            // Returns x / y
            return x / y;
        }
    }
}
