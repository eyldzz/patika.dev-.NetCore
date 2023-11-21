using System.Security.Cryptography;

namespace for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // odd numbers from one to the entered integer
               Console.Write("enter integer: ");
               int number = int.Parse(Console.ReadLine());
               if (number < 1)
                   Console.WriteLine("integer must be bigger than 0");
               else
               {
                   for(int i=1;i<=number;i++)
                   {
                       if (i % 2 == 1)
                           Console.WriteLine(i);
                   }
               }


            // the sum of odd and even numbers between 1 and 1000
            int oddSum = 0, evenSum = 0;
            for(int i=1;i<=1000;i++)
            {
                if (i % 2 == 1)
                    oddSum += i;
                else
                    evenSum += i;
            }
            Console.WriteLine("sum of odd numbers: " + oddSum );
            Console.WriteLine("sum of even numbers: " + evenSum);


        }
    }
}