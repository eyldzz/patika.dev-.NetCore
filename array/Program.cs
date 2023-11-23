using System.Collections;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array definition
            string[] colors = new string[5];
            string[] animals = { "cat", "dog", "bird", "monkey" };
            int[] arr;
            arr = new int[5];

            //assignment and accessing arrays
            colors[0] = "blue";
            arr[3] = 3;

            Console.WriteLine(animals[1]);
            Console.WriteLine(arr[3]);
            Console.WriteLine(colors[0]);

            //array with loops
            //program that calculates the average of n numbers entered from the keyboard
            Console.Write("enter length of array: ");
            int arraylenght=int.Parse(Console.ReadLine());
            int[] numberarr = new int[arraylenght];

            for (int i = 0;i< arraylenght; i++)
            {
                Console.Write("enter number {0} : " , i + 1);
                numberarr[i]=int.Parse(Console.ReadLine());
            }
            int total = 0;
            
            foreach(var num in numberarr)
                total+= num;
            Console.WriteLine("average: " + total / arraylenght);

        }
    }
}