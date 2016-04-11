using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class UserInput
    {
        public int CulculateBy()
        {
            Console.WriteLine("Would you like to 1: Add 2: Subtract 3: Multiple 4: Divide 5: Exponential ? ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public int FirstInput()
        {
            Console.WriteLine("Would is first number in your equation? ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public int SecondInput()
        {
            Console.WriteLine("What is the second number in your equation? ");
            return Convert.ToInt32(Console.ReadLine());
        }

    }
}
