using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    //Observable
    internal class Subject
    {
        List<Observer> observers = new();

        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}
