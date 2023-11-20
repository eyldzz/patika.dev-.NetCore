namespace typeConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit
            byte a = 5;
            sbyte b = 30;
            short c = 10;
            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = 5;
            Console.WriteLine("i: " + i);

            string e = "emre";
            char f = 'y';
            object o1 = e + f + d;
            Console.WriteLine("o1: " + o1);

            //Explicit
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            sbyte s1 = (sbyte)z;
            Console.WriteLine("s1: " + s1);

            float w = 10.3f;
            byte b1 = (byte)w;
            Console.WriteLine("b1: " + b1);

            //ToString

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);


            //System.Convert
            string str1 = "10", str2 = "20";
            int num1, num2, sum;
            num1 = Convert.ToInt32(str1);
            num2 = Convert.ToInt32(str2);
            sum = num1 + num2;
            Console.WriteLine("sum: " + sum);

            //Parse

            string str3 = "10";
            int num3 = Int32.Parse(str3);
            Console.WriteLine("num3: " + num3);
        }
    }
}