using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Payslip
{
    [TestClass]
    public class CalculatorShould
    {
        [TestMethod]
        public void FailNameTest()
        {
            string fname = "Me";                    //inputs
            string lname = "Me";

            Calculator eg = new Calculator(); // create a class for the logic
            string name = eg.combineFirstAndLastName(fname, lname);
            // string name = fname + lname; -- logic shouldnt be part of test

            Assert.AreEqual("MeMe", name);
        }

        [TestMethod]
        public void anotherTest()
        {

        }


    }
}
