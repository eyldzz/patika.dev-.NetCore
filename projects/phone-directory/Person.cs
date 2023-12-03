using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone_directory
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string phoneNum;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }

        public Person() { }
        public Person(string _firstName, string _lastName, string _phoneNum)
        {
            FirstName = _firstName;
            LastName = _lastName;
            PhoneNum = _phoneNum;
        }
    }
}
