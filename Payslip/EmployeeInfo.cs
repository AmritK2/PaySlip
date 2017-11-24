using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip
{
    public class EmployeeInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; }

        public override string ToString()
        {
            return (FirstName + " " + LastName);
        }

    }

    
}
