using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class check
    {
        public static void print(int[] inputArray)
        {
            foreach(int Check in inputArray)
            {
                Console.WriteLine(Check);

            }

        }
        public static void print(double[] inputArray)
        {
            foreach(double Check in inputArray)
            {
                Console.WriteLine(Check);

            }
        }
        public static void print(char[] inputArray)
        {
            foreach(char Check in inputArray)
            {
                Console.WriteLine(Check);

            }
        }
    }
}
