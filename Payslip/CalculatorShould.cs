using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class CalculatorShould
    {
        [TestMethod]
        public void PayPeriod()
        {
            string period = "March";
            //PayCalculator calculator = new PayCalculator();

            Assert.AreEqual("March", period);
        }

        [TestMethod]
        public void GIncome()
        {
            int salary = 12000;
            PayCalculator Income = new PayCalculator();
            int gIncome = Income.calculateGrossIncome(salary);

            Assert.AreEqual(1000,gIncome);
        }

        /*
        [TestMethod]
        public void JunkGIncome()
        {
            int salary = 18000;
            PayCalculator Income = new PayCalculator();
            int gIncome = Income.calculateGrossIncome(salary);

            Assert.AreEqual(1500, gIncome); //how will the actual result change based on user input
        }
        */

        [TestMethod]
        public void TIncome()
        {
            double income = 18300;
            PayCalculator tax = new PayCalculator();
            double tIncome = tax.calculateIncomeTax(income);

            Assert.AreEqual(19, tIncome);
        }

        

    }
}
