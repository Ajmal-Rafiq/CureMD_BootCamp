using System;

namespace S3_T15_4831
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Height Of The Triangle :");
            int Num = Convert.ToInt16(Console.ReadLine());//Initiializing Num for saving the value of user input for height 

            for (int i = 1; i <= Num; i++)//this loop is for controling the height of the triangle 
            {
                for (int j = 1; j <= Num-i; j++)//this loop is for printing the spaces '' in a line
                {
                    Console.Write(" ");

                }
                for (int k =1; k <= 2*i-1; k++)//this loop is for printing the number of '*' in a line
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }
        }
    }
}
