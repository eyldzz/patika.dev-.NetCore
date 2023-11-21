namespace tryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());

                int b = int.Parse(Console.ReadLine());

                int c = a + b;

                Console.WriteLine(c);
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("proccess done");
            }


            try
            {
                int a = int.Parse(null);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("cannot be null \n "+ e);

            }
        }
    }
}