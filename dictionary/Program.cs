using System;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Collection.Generic library
            Dictionary<int,string> users = new Dictionary<int,string>();
            users.Add(10, "Emre Yildiz");
            users.Add(12, "Burak Kizilkaya");
            users.Add(18, "Emin Yildiz");
            users.Add(20, "Murat Barbaros");

            //access to elements
            Console.WriteLine("***** Access To Elements *****");
            Console.WriteLine(users[12]);
            foreach (var i in users)
                Console.WriteLine(i);

            //Count
            Console.WriteLine("\n***** Count *****");
            Console.WriteLine("users Dictionary count: " + users.Count);

            //Contains
            Console.WriteLine("\n***** Contains *****");
            Console.WriteLine(users.ContainsKey(12));
            Console.WriteLine(users.ContainsValue("Murat"));

            //Remove
            Console.WriteLine("\n***** Remove *****");
            users.Remove(18);
            foreach (var i in users)
                Console.WriteLine(i.Value);

            //Keys
            Console.WriteLine("\n***** Keys *****");
            foreach (var i in users.Keys)
                Console.WriteLine(i);

            //Value
            Console.WriteLine("\n***** Values *****");
            foreach (var i in users.Values)
                Console.WriteLine(i);

        }
    }
}