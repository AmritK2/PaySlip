using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Payslip
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NoClue()
        {
            string fname = "Me";                    //inputs
            string lname = "Me";

            string name = fname + lname;

            Assert.AreEqual(3, name);
        }


    }
}
