namespace genericList
{
    internal class Program
    {
        public class Users
        {
            private string firstName, lastName;
            private int age;

            public string _firstname { get=>firstName; set => firstName = value; }
            public string _lastname { get=>lastName; set => lastName = value; }
            public int _age { get => age; set => age = value; }

        }

        public static void Main(string[] args)
        {
            //List<T> class
            //System.Collection.Generic library
            //T -> object type

            List<int> numList = new List<int>();
            numList.Add(1);
            numList.Add(3);
            numList.Add(5);
            numList.Add(7);
            numList.Add(8);
            numList.Add(10);

            List<string> colorList = new List<string>();
            colorList.Add("Red");
            colorList.Add("Blue");
            colorList.Add("Orange");
            colorList.Add("Yellow");
            colorList.Add("Green");

            //Count
            Console.WriteLine("numList Count: " + numList.Count);
            Console.WriteLine("colorList Count: " + colorList.Count);

            //Foreach and List.ForEach
            Console.Write("numList: ");
            foreach (var num in numList)
                Console.Write(num + " ");
            Console.Write("\ncolorList: ");
            foreach (var color in colorList)
                Console.Write(color + " ");

            Console.WriteLine("\n");

            numList.ForEach(num => Console.Write(num + " "));
            Console.WriteLine();
            colorList.ForEach(color => Console.Write(color + " "));
            Console.WriteLine("\n");

            //Remove element from list
            numList.Remove(1);
            colorList.Remove("Blue");

            numList.RemoveAt(0);
            colorList.RemoveAt(1);

            numList.ForEach(num => Console.WriteLine(num));
            colorList.ForEach(color => Console.WriteLine(color));

            //Search in List
            if (numList.Contains(11))
                Console.WriteLine("contain!");
            else
                Console.WriteLine("not contain!");

            //access to index with element
            Console.WriteLine(colorList.BinarySearch("Red"));

            //convert array to list
            string[] animals = { "cat", "dog", "bird" };
            List<string> animalList = new List<string>(animals);

            //remove all elements from list
            animalList.Clear();

            //store object in list
            List<Users> userList = new List<Users>();
            Users user1 = new Users();
            user1._firstname = "Emre";
            user1._lastname = "Yildiz";
            user1._age = 24;

            Users user2 = new Users();
            user2._firstname = "Burak";
            user2._lastname = "Kizilkaya";
            user2._age = 24;

            userList.Add(user1);
            userList.Add(user2);

            List<Users> user = new List<Users>();
            user.Add(new Users() {
                _firstname = "Emin",
                _lastname = "Yildiz",
                _age = 16

            });

            foreach (var item in userList)
            {
                Console.WriteLine("User First Name: " + item._firstname);
                Console.WriteLine("User Last Name: " + item._lastname);
                Console.WriteLine("User Age: " + item._age);
            }


        }
    }
}