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
        public void TestGIncome()
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
        
        /*
        [TestMethod]
        public void TestTIncome()
        {
            double income = 150000;
            PayCalculator tax = new PayCalculator();
            double tIncome = tax.calculateIncomeTax(income);

            Assert.AreEqual(43447, tIncome);
        }
        */

        [TestMethod]
        public void NIncome()
        {
            double gIncome = 1000;
            double tIncome = 100;

            PayCalculator netIncome = new PayCalculator();
            double nIncome = netIncome.calculateNetIncome(gIncome,tIncome);

            Assert.AreEqual(900, nIncome);
        }

        /*
        [TestMethod]
        public void TestNIncome()
        {
            double gIncome = 2000;
            double tIncome = 500;

            PayCalculator netIncome = new PayCalculator();
            double nIncome = netIncome.calculateNetIncome(gIncome, tIncome);

            Assert.AreEqual(1500, nIncome);
        }
        */

        [TestMethod]
        public void Super()
        {
            double rate = 9;
            double netIncome = 5000;
            
            PayCalculator super = new PayCalculator();
            double superRate = super.calculateSuperRate(rate, netIncome);

            Assert.AreEqual(450, superRate);
        }

        [TestMethod]
        public void TestSuper()
        {
            double rate = 7;
            double netIncome = 6000;

            PayCalculator super = new PayCalculator();
            double superRate = super.calculateSuperRate(rate, netIncome);

            Assert.AreEqual(420, superRate);
        }
    }
}
