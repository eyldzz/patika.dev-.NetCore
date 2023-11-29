using System.Collections;

namespace collectionQuestion2
{
    internal class Program
    {
        // Write a program that finds the highest 3 and the lowest 3 of 20 numbers entered from the keyboard
        // averages the two groups within itself, and prints these averages and average sums to the console. (Write using the Array class.)

        public static void print(int[] param)
        {
            foreach(int i in param)
            {
                Console.Write(i + " ");
            }
        }

        public static void Main(string[] args)
        {
            int num = 0;
            int[] arr = new int[20];
            for(int i = 0;i < 20; i++)
            {
                Console.Write($"Enter {i+1}. integer value: ");
                if (int.TryParse(Console.ReadLine(), out num))
                    arr[i] = num;
                else
                {
                    Console.WriteLine("Value must be integer ");
                    i--;
                }   
            }
            Array.Sort(arr);
            int[] lows = new int[3];
            for (int i =0 ; i < 3 ; i++)
                lows[i] = arr[i];
            
            int[] highs = new int[3];
            int cntr = 0;
            for(int i = arr.Length-1; i>arr.Length-4;i--)
            {
                highs[cntr] = arr[i];
                cntr++;
            }
            Console.Write("Lowest 3 integers: ");
            print(lows); 
            Console.Write("\nHighest 3 integers: ");
            print(highs);

            Console.WriteLine("\n\nLowest 3 integers average: " + lows.Average());
            Console.WriteLine("Highest 3 integers average: " + highs.Average());
            int averagessum = (int)(highs.Average() + lows.Average());
            Console.WriteLine("Lowest and highest averages total: " + averagessum);




        }
    }
}