using System;

namespace S2_T6_4831
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Sum1toN();
        }
        
        static void Sum1toN()
        {
            Console.WriteLine("Calculating The Sum Of All The Numbers from 1 to N" );
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enter the Value Of N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            for (int i=1;i<=N; i++)
            {
                total = total + i;
            }
            Console.WriteLine("Sum of all the Numbers from 1 to N is: " + total);

        }

    }
}
