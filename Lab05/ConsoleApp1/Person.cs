using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public readonly static Person NewlyBornChild = new Person("", "") { BirthDate = DateTime.Today };
        public Person()
        {

        }
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmailAddress { get; set; }
        public int? Height { get; set; }


        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public int GetAge()
        {
            return DateTime.Now.Year - this.BirthDate.Year;
        }

        public bool IsAdult()
        {
            return this.GetAge() > 18;
        }
    }
}