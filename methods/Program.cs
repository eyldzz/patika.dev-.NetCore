namespace methods
{

    class Methods
    {
        public void print(string _value)
        {
            Console.WriteLine(_value);
        }
        public int increaseandsum(ref int _a, ref int _b)
        {
            _a += 1;
            _b += 1;
            return (_a+ _b);
        }
    }
    class Program
    {

        static int Sum(int _a, int _b)
        {
            return _a + _b;
        }
          
        public static void Main(string[] args)
        {
            int a = 2, b = 3;
            Console.WriteLine(a + b);
            int total= Sum(a, b);
            Console.WriteLine(total);

            Methods obj = new Methods();
            obj.print(total.ToString());

            int total2 = obj.increaseandsum(ref a, ref b);
            obj.print(total2.ToString());
            obj.print((a + b).ToString());



        }
    }
}