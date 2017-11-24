using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payslip;

namespace Calculator
{
    [TestClass]
    public class PayslipShould
    {
        [TestMethod]
        public void GetInput()
        {
            string userInput = "David,Rudd,600050,9%,01 March- 31 March";
            Payslip payslip = new Payslip();
            EmployeeInfo name = payslip.SplitTheInput(userInput);

            //Assert.AreEqual("David Rudd", name.ToString());
            Assert.AreEqual("600050", name.Salary);
        }

        [TestMethod]
        public void GiveFullName()
        {
            
            string firstName = "David";
            string lastName = "Rudd";

            Payslip payslip = new Payslip();
            var name = payslip.GetFullName(firstName,lastName);

            Assert.AreEqual("David Rudd", name);
        }
        
    } 
}
