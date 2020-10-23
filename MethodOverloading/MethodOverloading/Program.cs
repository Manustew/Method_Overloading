using System;
using System.Reflection.Metadata.Ecma335;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(0, 1, false));
        }

        //Base Add
        public static int Add(int a, int b)
        {
            return a + b;
        }
        //Overload for doubles
        public static double Add(double a, double b)
        {
            return a + b;
        }
        //Overload to show dollar amount
        public static string Add(int a, int b, bool shouldAddDollars)
        {
            int c = a + b;
            if (shouldAddDollars == true && c == 1)
                return ($"Value is {c} dollar");
            if (shouldAddDollars == true && c != 1)
                return ($"Value is {c} dollars");
            else
                return ($"Value is {c}");
        }


    }

}
