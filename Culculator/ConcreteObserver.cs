using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ConcreteObserver : Observer
    {
        private int _name;
        private int _observerState;
        private ConcreteSubject _subject;

        public ConcreteObserver(
            ConcreteSubject subject, int name)
        {
            this._subject = subject;
            this._name = name;
        }
        public override void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine("The total is {0}", _observerState);
        }
        public ConcreteSubject Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
    }
}
