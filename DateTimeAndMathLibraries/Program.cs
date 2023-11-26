namespace DateTimeAndMathLibraries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.Year);
            //DateTime Formats
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));
            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));
            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));

            //Math Library
            Console.WriteLine(Math.Abs(-10));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(15.2));
            Console.WriteLine(Math.Round(15.2));
            Console.WriteLine(Math.Round(15.7));
            Console.WriteLine(Math.Floor(15.7));

            Console.WriteLine(Math.Max(5, 15));
            Console.WriteLine(Math.Min(5, 15));

            Console.WriteLine(Math.Pow(2, 5));
            Console.WriteLine(Math.Sqrt(81));
            Console.WriteLine(Math.Log(9));
            Console.WriteLine(Math.Exp(3));
            Console.WriteLine(Math.Log10(10));
        }
    }
}