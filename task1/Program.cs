using System.Runtime.CompilerServices;

namespace task1
{
    public static class Extension
    {
        public static bool isEven(this int param)
        {
            return param % 2 == 0;
        }
        public static bool isEqualOrDividable(this int param, int divider)
        {
            return param % divider == 0;
        }
        
        
    }

    internal class Program
    {
        public static void EvenNumbers() // question 1
        {
            Console.Write("enter positive number for array lenght: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. number: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Even numbers: ");
            foreach (var i in arr)
            {
                if (i.isEven())
                    Console.Write(i + " ");
            }
        }

        public static void Dividing() // question 2
        {
            int num1, num2;
            Console.Write("enter lenght of positive numbers: ");
            num1= int.Parse(Console.ReadLine());
            Console.Write("enter divider positive number: ");
            num2 = int.Parse(Console.ReadLine());
            int[] arr = new int[num1];
            for(int i = 0; i < num1; i++)
            {
                Console.Write("{0}. number: ",i+1);
                arr[i]=int.Parse(Console.ReadLine());
            }
            Console.Write("dividable and equal numbers for {0}: ",num2);
            foreach (var i in arr)
            {
                if (i.isEqualOrDividable(num2))
                    Console.Write(i + " ");
            }


        }

        public static void ReversedWords() // question 3
        {
            int n;
            Console.Write("how many words will you write?: ");
            n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("{0}. word: ", i+1);
                arr[i] = Console.ReadLine();
            }
            Console.Write("word list: ");
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nreversed word list: ");
            for(int i = arr.Length-1;i >=0; i--)
            {
                Console.Write(arr[i] + " ");
            }

        }
        
        public static void WordAndCharacterCounter() // question 4
        {
            Console.Write("enter a sentence: ");
            string str = Console.ReadLine();
            string[] arr = str.Split(" ");
            int num = str.Replace(" ", "").Length;
            Console.WriteLine("total words: " + arr.Length);
            Console.WriteLine("total character: " + num);
        }



        public static void Main(string[] args)
        {
         //  EvenNumbers();
         //  Dividing();
         //  ReversedWords();
         //  WordAndCharacterCounter();
        }
    }
}