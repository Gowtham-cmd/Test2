using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonExample
{
    public class PermanentEmployee : Employee
    {
        public override int GetSalary()
        {
            return 500;
        }

        //static PermanentEmployee() -Static Constructor
        //{

        //}
        //public PermanentEmployee()  - Default Constructor
        //{
        //    EmployeeName = "Gowtham";
        //}

        //public PermanentEmployee(string Name) - Parmetrized Contructor
        //{
        //    EmployeeName = Name;
        //}

        //string name;
        //int age;
        //public PermanentEmployee(PermanentEmployee obj) - Copy Contructor
        //{
        //    name = obj.name;
        //    age = obj.Age;
        //}



    }
}
