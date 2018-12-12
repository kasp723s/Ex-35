using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_35
{
    public abstract class Subject
    {
        internal List<Observer> observers = new List<Observer>();
        public void Attach(Observer observer)
        {
            observers.Add(observer);

        }
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            {
                foreach (Observer observer in observers)
                {
                    observer.Update();
                }
            }
        }
    }

    
}
