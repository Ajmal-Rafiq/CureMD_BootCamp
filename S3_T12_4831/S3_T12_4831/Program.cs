using System;

namespace S3_T12_4831
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Hello World!");
            Palindrome();// Calling the palindrome function
        }

        static void Palindrome()
        {
            string reverse=null;
            Console.WriteLine("Finding if the String Is Palindrome ");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enter the String You Want To Know Is Panlindrome: ");
            string input = Console.ReadLine();//Taking Input For The String 

            for (int i = input.Length-1; i >=0;i--)
            {
                reverse += input[i].ToString();//appending char by char in reverse string 
            }
            if (input.ToLower() == reverse.ToLower())//Lower casing both string and comparing that both are equal
            {
                Console.WriteLine(" The String Is Palindrome ");//print the result whether the string is palindrome or not
            }
            else
            {
                Console.WriteLine(" The String Is Not Palindrome ");//print the result whether the string is palindrome or not

            }
            

        }



    }
}
