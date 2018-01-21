using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class CalculatorShould
    {
        [TestMethod]
        public void GivePayPeriod()
        {
            string period = "01 March to 31 March";
            PayCalculator calculator = new PayCalculator();
            string payPeriod = calculator.calculatePayPeriod(period);

            Assert.AreEqual("01 March to 31 March", payPeriod);
        }

        [TestMethod]
        public void GiveGrossIncome()
        {
            int salary = 12000;
            PayCalculator calculator = new PayCalculator();  //calc
            int gIncome = calculator.calculateGrossIncome(salary);

            Assert.AreEqual(1000, gIncome);
        }

        [TestMethod]
        public void GiveTaxIncome()
        {
            double income = 18300;
            PayCalculator calculator = new PayCalculator();
            double tIncome = calculator.calculateIncomeTax(income);

            Assert.AreEqual(19, tIncome);
        }
        
        [TestMethod]
        public void GiveNetIncome()
        {
            double gIncome = 1000;
            double tIncome = 100;

            PayCalculator calculator = new PayCalculator();
            double nIncome = calculator.calculateNetIncome(gIncome,tIncome);

            Assert.AreEqual(900, nIncome);
        }

        [TestMethod]
        public void GiveSuper()
        {
            double rate = 9;
            double netIncome = 5000;
            
            PayCalculator calculator = new PayCalculator();
            double superRate = calculator.calculateSuperRate(rate, netIncome);

            Assert.AreEqual(450, superRate);
        }
    }
}

