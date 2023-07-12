using System;

namespace S4_T16_4831
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reversing The String: ");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enter the String You Want To Reverse: ");
            string input = Console.ReadLine();//Taking Input For The String 
            String reverse = reverseString(input);//calling the function
            Console.WriteLine(reverse);


        }

        static String reverseString(string input)
        {
            string reverse = null;
            

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i].ToString();//appending char by char in reverse string 
            }

            return reverse;


        } 

    }
}
