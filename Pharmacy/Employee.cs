using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class Employee
    {
        public string first_name { get; private set; }
        public string last_name { get; private set; }
        private int salary;
        public Employee(string f, string l, int s)
        {
            first_name = f;
            last_name = l;
            salary = s;
        }
        public override string ToString()
        {
            return first_name + " " + last_name;
        }
    }
}
