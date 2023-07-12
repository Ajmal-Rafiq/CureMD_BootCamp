using System;

namespace S2_T7_4831
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            multiplication_table();//calling the multiplication table function in main 
        }
        static void multiplication_table()
        {
            Console.WriteLine("Calculating The Multiplication Table of Number Given by User Up to 12 ");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enter the Value Of Number For Its Table : ");
            int Num = Convert.ToInt32(Console.ReadLine());//Intializing Num variable and taking user value 
            for (int i = 1; i <= 12; i++)
            {

                Console.WriteLine(Num + " x " + i + " = " + Num * i); // printing the multiplication table of the user entered number upto 12.
            
            }

        }



    }
}
