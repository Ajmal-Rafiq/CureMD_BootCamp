using System;

namespace S2_T10_4831
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Fabonacci();//calling the fabonacci funtion
        }
        
        static void Fabonacci()
        {

            int[] fabonacci = {0,1,0};// initialing an array of 3 elements with their initial values 

            Console.WriteLine("Calculating The Fabonacci Upto to Number");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enter the Number Upto Where You Want To Find The Fabonacci Seqence: ");
            int Num = Convert.ToInt32(Console.ReadLine());//initalizing the Num var and taking the user input value upto to where the sequence will go
            Console.Write("Fabonacci Series : " + fabonacci[0]+ " " + fabonacci[1]+ " ");//print the first 2 number of seq
            for (int i =2;i< Num;i++)
            {

                Console.Write((fabonacci[2] = fabonacci[0] + fabonacci[1])+" ");// printing and saving the sum of previous two values 
                fabonacci[0] = fabonacci[1];//updating the value of previous with the next value 
                fabonacci[1] = fabonacci[2];//updating the value of previous with the next value 

            }
        }

    
    
    
    }
}
