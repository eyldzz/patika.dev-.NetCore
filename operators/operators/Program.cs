namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //assignment 
            int x = 3;
            int y = 5;
            y += 2;
            x -= 1;

            //logical 

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect!");
            if (isSuccess || isCompleted)
                Console.WriteLine("Great!");
            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine!");

            // comparison

            int a = 3;
            int b = 4;
            bool result = a < b;
            Console.WriteLine(result);
            result = a == b;
            Console.WriteLine(result);

            //arithmetic
            int num1 = 10;
            int num2 = 4;
            int num3 = num1 * num2;
            Console.WriteLine(num3);
            num3 = num1 / num2;
            Console.WriteLine(num3);
            num3 = num1 + num2;
            Console.WriteLine(num3);
            num3 = num1 - num2;
            Console.WriteLine(num3);
            Console.WriteLine(++num1);
            Console.WriteLine(num2 *= 4);


            //mod

            num3 = num1 % num2;
            Console.WriteLine(num3);
        }
    }
}