using System;

namespace S2_T9_4831
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Factorial();

        }
    
        static void Factorial()
        {
            int fact = 1;//Initialing variable to save the value of the factorial after every iter
            Console.WriteLine("Calculating The Factorial of Given Number");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enter the Number You Want To Find The Factorial of: ");
            int Num = Convert.ToInt32(Console.ReadLine());//Initializing the Num var and taking user input for which number facorial is to be found.  
            for (int i = 1; i <= Num; i++)
            {
                
                fact *= i;//saving value of factorail after every iter
            }
            Console.Write("Factorial of " + Num + " is: " + fact);//displaying at the console the value of factorial


        }
    
    }


}
