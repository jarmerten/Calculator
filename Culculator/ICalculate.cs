using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface ICalculate
    {
        int CalculateTotal(int numberOne, int numberTwo);
        void PrintResults(int total);
    }
}
