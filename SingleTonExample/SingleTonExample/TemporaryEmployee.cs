using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonExample
{
    public class TemporaryEmployee : Employee
    {
        public override int GetSalary()
        {
            return 300;
        }
    }
}
