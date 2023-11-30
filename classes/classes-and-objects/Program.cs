namespace classes_and_objects
{
    class Employees
    {
        public string firstName, lastName;
        public int num;
        public string department;

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
            Employees emp1 = new Employees();
            emp1.firstName = "Emre";
            emp1.lastName = "Yildiz";
            emp1.num = 184212;
            emp1.department = "Information Technology";
            emp1.EmployeeInfos();

            Console.WriteLine("\n");

            Employees emp2 = new Employees();
            emp2.firstName = "Burak";
            emp2.lastName = "Kizilkaya";
            emp2.num = 141841;
            emp2.department = "Development";
            emp2.EmployeeInfos();


        }
    }
}