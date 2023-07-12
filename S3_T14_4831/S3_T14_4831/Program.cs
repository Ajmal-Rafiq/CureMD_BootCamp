using System;

namespace S3_T14_4831
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Height Of The Triangle :");
            int Num = Convert.ToInt16(Console.ReadLine());//Initiializing Num for saving the value of user input for height 
            
            for (int i=1; i<=Num; i++)//this loop is for controling the height of the triangle 
            {
                for (int j=1; j<=i;j++)//this loop is for printing the number of '*' in a line
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
