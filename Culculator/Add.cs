using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Add : ICalculate
    {
        int combinedTotal;
        public int CalculateTotal(int numberOne, int numberTwo)
        {
            combinedTotal = numberOne + numberTwo;
            return combinedTotal;
        }
        public void PrintResults(int total)
        {
            Console.WriteLine("The total is " + total);
        }
    }
}
