using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Facade
    {
        int firstNumber;
        int secondNumber;
        int total;
        private Add _one;
        private Subtract _two;
        private Multiple _three;
        private Divide _four;

        public Facade()
        {
            _one = new Add();
            _two = new Subtract();
            _three = new Multiple();
            _four = new Divide();
        }
        public void Adding(int firstNumber, int secondNumber)
        {
            total = _one.CalculateTotal(firstNumber, secondNumber);
            _one.PrintResults(total);
        }
        public void Subtracting(int firstNumber, int secondNumber)
        {
            total = _two.CalculateTotal(firstNumber, secondNumber);
            _two.PrintResults(total);
        }
        public void Multiplying(int firstNumber, int secondNumber)
        {
            total = _three.CalculateTotal(firstNumber, secondNumber);
            _three.PrintResults(total);
        }
        public void Dividing(int firstNumber, int secondNumber)
        {
            total = _four.CalculateTotal(firstNumber, secondNumber);
            _four.PrintResults(total);
        }


    }
}
