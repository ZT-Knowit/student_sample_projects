using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum Gender
    {
        Female,
        Male,
        Binary,
        Other
    }
    public class Coach
    {
        public Gender Gender;
        public string Name;
        public DateTime BirthDate;
        private decimal _salary;

        public Coach(Gender gender, string name, DateTime birthDate)
        {
            Gender = gender;
            Name = name;
            BirthDate = birthDate;
        }

        public void PaySalary(decimal amount)
        {
            _salary = amount;
            Console.WriteLine($"Betalar ut {amount} kr i lön till tränaren {Name}.");
        }
    }
}
