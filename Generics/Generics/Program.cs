using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };
            double[] doubleArray = { 1.1, 2.1, 3.1, 4.1, 5.1, 32.1 };
            char[] charArray = { 'R', 'i', 's','h', 'i' };
            Console.WriteLine("Array of Integer Double And Character Using Generics");
            int op = check.MaximumNumber(11, 22, 33);
            Console.WriteLine(op);
            double f = check.DoubleMaximumNumber(11.11, 22.11, 22.22);
            Console.WriteLine(f);

        }
    }
}
