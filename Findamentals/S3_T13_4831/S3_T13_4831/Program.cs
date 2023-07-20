using System;

namespace S3_T13_4831
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Calculating The Largest Number and Smallest in An Array");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            int[] array = { 3, 5, 7, 2, 8, 9,1 };
            int len = array.Length;
            int minValue = int.MaxValue;  // Initialize minValue to maximum possible value
            int maxValue = int.MinValue;  // Initialize maxValue to minimum possible value

            for (int i = 0; i < len; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }

                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            Console.WriteLine("Min Value of Array: " + minValue);
            Console.WriteLine("Max Value of Array: " + maxValue);



        }
    }
}
