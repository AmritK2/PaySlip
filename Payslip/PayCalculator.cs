using System;

namespace Calculator
{
    internal class PayCalculator
    {
        internal string FindPeriod()
        {

           throw new NotImplementedException();
        }

        internal int calculateGrossIncome(int salary)
        {
            int result = salary / 12;
            return result;
            //throw new NotImplementedException();
        }

        internal double calculateIncomeTax(double income)
        {
            double Income = income - 18200;
            double result = 0.19 * Income;
            return result;
            //throw new NotImplementedException();
        }
    }
}