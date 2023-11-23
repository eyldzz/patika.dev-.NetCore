namespace while_foreach_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while
            Console.Write("enter a integer: ");
            int number = int.Parse(Console.ReadLine());
            int total = 0;int counter = 1;
            while(counter<=number)
            {
                total += counter;
                counter++;
            }
            Console.WriteLine(total / number);
            
            //foreach

            int[] numbers= {1,2,3,4,5,6,7};
            foreach(var num  in numbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}