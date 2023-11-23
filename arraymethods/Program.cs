namespace arraymethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sort
            Console.WriteLine("********Array Sort********");
            int[] arr = { 5, 2, 3, 9, 23, 51, 17, 4, 11 };
            foreach (int i in arr)
                Console.WriteLine(i);
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            //clear
            Console.WriteLine("********Array Clear********");
            Array.Clear(arr, 2, 2);
            foreach (int i in arr)
                Console.WriteLine(i);

            Array.Reverse(arr);

            foreach (int i in arr)
                Console.WriteLine(i);

            //Indexof
            Console.WriteLine("********Array Indexof********");
            Console.WriteLine(Array.IndexOf(arr, 9));

            //resize
            Console.WriteLine("********Array Resize********");
            Array.Resize<int>(ref arr, 10);
            arr[9] = 99;
            foreach (int i in arr)
                Console.WriteLine(i);

        }
    }
}