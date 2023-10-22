using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public string Gender;
        public double Salary;

        public Employee(int id, string name, string gender, double salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
    }
}
