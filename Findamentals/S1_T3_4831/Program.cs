using System;

namespace S1_T3_4831
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();// calling the sum function
        }


        static void Sum() 
        {
            int first_number;
            int second_number;
            Console.WriteLine("Enter the First Digit");
            first_number = Convert.ToInt32(Console.ReadLine());//taking user input and converting it into intteger
            Console.WriteLine("Enter the Second Digit");
            second_number = Convert.ToInt32(Console.ReadLine());//taking user input and converting it into intteger
            int sum = first_number + second_number;//doing the sum of user entered numbers
            Console.WriteLine("Sum of the Number is :" + sum);// print the sum of the numbers
            
        } 
    }
}
