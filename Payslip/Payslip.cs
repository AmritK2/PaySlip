using Payslip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Payslip
    {
        internal string GetFullName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }

        public EmployeeInfo SplitTheInput(string userInput)
        {
            string s = userInput;
            string[] values = s.Split(','); //1,2,3 => int[] {1,2,3}
            var empInfo = new EmployeeInfo();
            empInfo.FirstName = values[0];
            empInfo.LastName = values[1];
            empInfo.Salary = values[2];

            //GetFullName(empInfo.FirstName, empInfo.LastName);
            return empInfo;
        }
    }
}
