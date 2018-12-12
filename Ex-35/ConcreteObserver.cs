using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_35
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject;

        private int state = 0;
        public int State
        {
            get { return state; }
            set { state = value; }
        }

        public ConcreteObserver(ConcreteSubject subject) //Constructor
        {
            this.subject = subject;
        }

        public override void Update()
        {
            State = subject.State;
        }
    }


}
