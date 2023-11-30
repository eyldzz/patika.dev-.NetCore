namespace encapsulation_and_property
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int stdNum;
        private int stdClass;

        public string FirstName
        { 
            get { return firstName; }
            set { firstName = value; } 
        }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int StdNum { get {  return stdNum; } set {  stdNum = value; } }
        public int StdClass
        {
            get { return stdClass; }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Grade cant lower than 1!");
                    stdClass = 1;
                }
                else
                    stdClass = value; 
            } 
        }

        public Student(string _firstName, string _lastName, int _stdNum, int _stdClass)//constructor with parameters
        {
            FirstName = _firstName;
            lastName = _lastName;
            stdNum = _stdNum;
            stdClass = _stdClass;
        }

        public Student() { }//constructor with non parameters

        public void PrintStudentInfos()
        {
            Console.WriteLine("*****  Student Infos  *****");
            Console.WriteLine($"Student First Name  : {this.FirstName}");
            Console.WriteLine($"Student Last Name   : {this.LastName}");
            Console.WriteLine($"Student Number      : {this.StdNum}");
            Console.WriteLine($"Student Class       : {this.StdClass}");
        }
        public void UpGrade()
        {
            this.StdClass += 1;
        }
        public void DownGrade()
        {
            this.StdClass -= 1;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.FirstName = "Emre";
            std1.LastName = "Yildiz";
            std1.StdNum = 23;
            std1.StdClass = 10;
            std1.PrintStudentInfos();

            Console.WriteLine("\n");

            Student std2 = new Student("Burak", "Kizilkaya", 36, 1);
            std2.DownGrade();
            std2.DownGrade();
            std2.PrintStudentInfos();

        }
    }
}