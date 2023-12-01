namespace static_class_members
{
    class Employees
    {
        private static int employeeCount;

        public static int EmployeeCount { get { return employeeCount; } }

        private string firstName, lastName, department;
        
        static Employees()
        {
            employeeCount = 0; 
        }

        public Employees(string _firstName, string _lastName, string _department)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.department = _department;
            employeeCount++;
        }
    }

    static class Operations
    {
        public static int Sum (int _num1,int _num2)
        {
            return _num1 + _num2;
        }
        public static int Substraction(int _num1, int _num2)
        {
            return _num1 - _num2;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Count: " + Employees.EmployeeCount);

            Employees emp1 = new Employees("Emre", "Yildiz", "IT");
            Console.WriteLine("Employee Count: " + Employees.EmployeeCount);
            Employees emp2 = new Employees("Burak", "Kizilkaya", "IT");
            Employees emp3 = new Employees("Emin", "Yildiz", "IT");
            Console.WriteLine("Employee Count: " + Employees.EmployeeCount);

            Console.WriteLine("Sum: " + Operations.Sum(50, 120));
            Console.WriteLine("Substract: " + Operations.Substraction(170, 25));

        }
    }
}