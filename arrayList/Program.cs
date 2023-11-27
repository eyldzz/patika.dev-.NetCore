using System.Collections;

namespace arrayList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //System.Collection namespace

            ArrayList arr = new ArrayList();
        //    arr.Add("Emre");
        //    arr.Add(23);
        //    arr.Add(true);
        //    arr.Add('Y');

            //access to elements
        //    Console.WriteLine(arr[1]);
        //    foreach(var i in arr)        
        //        Console.WriteLine(i);

            //AddRange
            Console.WriteLine("***** AddRange *****");
        //  string[] colors = { "red", "green", "blue" };
            List<int> nums = new List<int>() {1,3,5,9,4,2,11,30,7 };
            arr.AddRange(nums);
        //  arr.AddRange(colors);

            foreach (var i in arr)
                Console.WriteLine(i);

            //Sort
            Console.WriteLine("***** Sort *****");
            arr.Sort();
            foreach (var i in arr)
                Console.WriteLine(i);

            //Binary Search
            Console.WriteLine("***** BinarySearch *****");
            Console.WriteLine(arr.BinarySearch(3));

            //Reverse
            Console.WriteLine("***** Reverse *****");
            arr.Reverse();
            foreach (var i in arr)
                Console.WriteLine(i);
        }
    }
}