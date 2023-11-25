namespace extensionAndRecursiveMethods
{
    public class Recursive
    {
        public int Expo(int _num, int _expo)                     // Expo(3,4);
        {                                                        // Expo(3,3) * 3;
            if (_expo < 2)                                       // Expo(3,2) * 3 * 3;
                return _num;                                     // Expo(3,1) * 3 * 3 * 3;
            return Expo(_num, _expo - 1) * _num;                 // 3*3*3*3 = 3^4;
        }
    }
    
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] arr = param.Split(" ");
            return string.Join("-", arr);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void Print(this int[] param)
        {
            foreach (var i in param)
                Console.WriteLine(i);
        }
        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }

    }

    internal class Program
    {

        public static void Main(string[] args)
        {
            // Recursive Methods
            // 3^4 = 3*3*3*3
            
            int result = 1;
            for (int i = 1; i < 5; i++)
                result *= 3;
            Console.WriteLine(result);

            // Extension Methods

            string str = "Emre Yildiz";
            bool answ = str.CheckSpaces(); 
            Console.WriteLine(answ);
            if (answ)
                Console.WriteLine(str.RemoveWhiteSpaces());
            Console.WriteLine(str.MakeUpperCase());
            Console.WriteLine(str.MakeLowerCase());

            int[] arr = { 9, 3, 4, 2, 5, 7, 8, 1 };
            arr.SortArray();
            arr.Print();

            int num = 5;
            Console.WriteLine(num.IsEvenNumber());

            Console.WriteLine(str.GetFirstCharacter());

        }
    }
}