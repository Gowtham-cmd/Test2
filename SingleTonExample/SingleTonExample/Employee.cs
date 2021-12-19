using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonExample
{
   public abstract class Employee
    {
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public abstract int GetSalary();
    }
}
