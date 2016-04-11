using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Math
    {
        UserInput user = new UserInput();
        public Math()
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int whereToGo = user.CulculateBy();
            firstNumber = user.FirstInput();
            secondNumber = user.SecondInput();
            Facade facade = new Facade();
            ConcreteSubject exponent = new ConcreteSubject();
            switch (whereToGo)
                {
                case 1:
                    {
                        facade.Adding(firstNumber, secondNumber);
                        break;
                    }
                case 2:
                    {
                        facade.Subtracting(firstNumber, secondNumber);
                        break;
                    }
                case 3:
                    {
                        facade.Multiplying(firstNumber, secondNumber);
                        break;
                    }
                case 4:
                    {
                        facade.Dividing(firstNumber, secondNumber);
                        break;
                    }
                default:
                    {
                        exponent.Attach(new ConcreteObserver(exponent, firstNumber));
                        Exponential exponents = new Exponential();
                        exponent.SubjectState = exponents.CalculateTotal(firstNumber);
                        exponent.Notify();
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
