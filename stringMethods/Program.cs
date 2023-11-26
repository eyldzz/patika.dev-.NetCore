namespace stringMethods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string str1 = "Practice makes perfect";
            string str2 = "Practice";

            //Lenght
            Console.WriteLine(str1.Length);

            //ToUpper, ToLower
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str1.ToLower());

            //Concat
            Console.WriteLine(String.Concat(str1, " things"));

            //Compare, CompareTo
            Console.WriteLine(str1.CompareTo(str2)); //-1,0,1
            Console.WriteLine(String.Compare(str1, str2,true));
            Console.WriteLine(String.Compare(str1, str2, false));

            //Contains
            Console.WriteLine(str1.Contains(str2));
            Console.WriteLine(str1.StartsWith("prac"));
            Console.WriteLine(str1.EndsWith("perfect"));

            //IndexOf
            Console.WriteLine(str1.IndexOf("ma"));
            Console.WriteLine(str1.IndexOf("emre"));
            Console.WriteLine(str1.LastIndexOf("c"));

            //Insert
            Console.WriteLine(str1.Insert(0, "Many "));

            //PadLeft, PadRight
            Console.WriteLine(str1 + str2.PadLeft(30,'*'));
            Console.WriteLine(str1.PadRight(40,'*') + str2);

            //Remove
            Console.WriteLine(str1.Remove(10));
            Console.WriteLine(str1.Remove(5,3));
            Console.WriteLine(str1.Remove(0,1));

            //Replace
            Console.WriteLine(str1.Replace("perfect","great"));
            Console.WriteLine(str1.Replace(" ", "*"));

            //Split
            Console.WriteLine(str1.Split(' ')[1]);

            //Substring
            Console.WriteLine(str1.Substring(3, 5));

        }
    }
}