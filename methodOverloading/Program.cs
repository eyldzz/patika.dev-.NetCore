namespace methodOverloading
{

    class Methods
    {
        public void sum(int _a, int _b, out int _c)
        {
            _c = _a + _b;
        }

        public void print(string _val)
        {
            Console.WriteLine(_val);
        }
        public void print(int _val)
        {
            Console.WriteLine(_val);
        }
        public void print(string _val, string _val2)
        {
            Console.WriteLine(_val + " " + _val2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //out parameters
            string num = "999";
            bool b1 = int.TryParse(num, out int outNum);
            if(b1==true)
            {
                Console.WriteLine("successful");
                Console.WriteLine(outNum);
            }
            else
                Console.WriteLine("unsuccessful");

            Methods obj = new Methods();
            obj.sum(4, 5, out int c);
            Console.WriteLine(c);


            //overloading
            //method signature = method name + number of parameter + type of parameter
            int val = 99;
            obj.print(val);
            obj.print(val.ToString());
            obj.print("Emre", "Yildiz");


            
                

        }
        
    }
    
}