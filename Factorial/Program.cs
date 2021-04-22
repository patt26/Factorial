using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

                int a = 1;
                int i = 0;
                int num = 0;
                Console.WriteLine("Enter Number");
                num = Convert.ToInt32(Console.ReadLine());

                for (i = 1; i <= num; i++)
                {
                    a = (a * i);
                }
                Console.WriteLine("Factorial of " + num + " is = " + a);


                //Console.ReadKey();
            
        }
    }

    
}