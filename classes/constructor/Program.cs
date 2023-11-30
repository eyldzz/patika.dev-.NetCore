namespace constructor
{
    class Employees
    {
        public string firstName, lastName;
        public int num;
        public string department;

        public Employees(string _firstName, string _lastName)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
        }

        public Employees(string _firstName, string _lastName, int _num, string _department)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.num = _num;
            this.department = _department;
        }
        public Employees() { } // for constructor that not take parameter

        public void EmployeeInfos()
        {
            Console.WriteLine("Employee First Name: " + firstName);
            Console.WriteLine("Employee Last Name: " + lastName);
            Console.WriteLine("Employee Number: " + num);
            Console.WriteLine("Employee Department: " + department);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tEmployee 1");
            Employees emp1 = new Employees("Emre","Yildiz",184212,"Informatin Technologies"); // use of constructor method
            emp1.EmployeeInfos();

            Console.WriteLine("\n\tEmployee 2");

            Employees emp2 = new Employees();
            emp2.firstName = "Burak";
            emp2.lastName = "Kizilkaya";
            emp2.num = 141841;
            emp2.department = "Development";
            emp2.EmployeeInfos();

            Console.WriteLine("\n\tEmployee 3");

            Employees emp3 = new Employees("Emin","Yildiz");
            emp3.EmployeeInfos();

        }
    }
}