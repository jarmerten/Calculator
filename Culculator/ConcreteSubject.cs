using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ConcreteSubject : Subject
    {
        private int _subjectState;
        public int SubjectState
        {
            get { return _subjectState; }
            set { _subjectState = value; }
        }
    }
}
