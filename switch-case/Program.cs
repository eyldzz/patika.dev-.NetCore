using System.Linq.Expressions;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("you are in january");
                    break;
                case 2:
                    Console.WriteLine("you are in february");
                    break;
                case 3:
                    Console.WriteLine("you are in march");
                    break;
                case 4:
                    Console.WriteLine("you are in april");
                    break;
                case 5:
                    Console.WriteLine("you are in may");
                    break;
                case 6:
                    Console.WriteLine("you are in june");
                    break;
                case 7:
                    Console.WriteLine("you are in july");
                    break;
                case 8:
                    Console.WriteLine("you are in august");
                    break;
                case 9:
                    Console.WriteLine("you are in september");
                    break;
                case 10:
                    Console.WriteLine("you are in octobor");
                    break;
                case 11:
                    Console.WriteLine("you are in november");
                    break;
                case 12:
                    Console.WriteLine("you are in december");
                    break;

            }

            switch(month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("winter");break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("spring");break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("summer");break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("autmn");break;


            }
        }
    }
}