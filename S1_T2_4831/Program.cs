using System;

namespace S1_T2_4831
{
    class Program
    {
        static void Main(string[] args)
        {
            NameGreeting();//Calling Func
        }

        static void NameGreeting()
        {
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();//taking input from the user 
            Console.WriteLine("Hello! " + name); // printing greeting with name 

        }

    }
}

