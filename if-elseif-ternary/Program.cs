namespace if_elseif_ternary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
                Console.WriteLine("Good morning!");
            else if (time <= 18)
                Console.WriteLine("Have a good day!");
            else
                Console.WriteLine("Good night!");

            string str = time >= 6 && time < 11 ? "Good morning!" : time <= 18 ? "Have a good day!" : "Good night!";
            Console.WriteLine(str);
            
        }
    }
}