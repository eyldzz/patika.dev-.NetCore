namespace enum_
{
    internal class Program
    {
        enum DaysOfWeek
        {
            Monday=1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Weather
        {
            Cold = 5,
            Cool = 20,
            Warm = 25,
            Hot = 30
        }


        static void Main(string[] args)
        {
            Console.WriteLine(DayOfWeek.Sunday);
            Console.WriteLine((int)DayOfWeek.Wednesday);

            int heat = 5;
            if (heat <= (int)Weather.Cool)
                Console.WriteLine("wait until the weather gets warmer to go outside");
            else if (heat >= (int)Weather.Hot)
                Console.WriteLine("too hot to go outside");
            else if (heat >= (int)Weather.Cool && heat <= (int)Weather.Hot)
                Console.WriteLine("lets go outside");
        }
    }
}