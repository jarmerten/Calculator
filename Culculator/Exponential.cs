using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Exponential
    {
        int combinedTotal = 0;
        public int CalculateTotal(int numberOne)
        {
            for( int i = 0; i < numberOne; i++)
            {
            combinedTotal = numberOne * numberOne;
            }
            return combinedTotal;
        }
        public void PrintResults(int total)
        {
            Console.WriteLine("The total is " + total);
        }
    }
}
