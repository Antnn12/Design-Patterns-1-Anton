using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment
{
    internal class Email1
    {
        public List<Observer1> ObserverList { get; set; }

        public Email1()
        {
            ObserverList = new();
        }

        public void Register(Observer1 observer)
        {
            ObserverList.Add(observer);
        }

        public void Unregister(Observer1 observer)
        {
            ObserverList.Remove(observer);
        }

        public void Notification()
        {
            foreach (var observer in ObserverList)
            {
                observer.Update("Email notification");
            }
        }

        internal string CheckTimer()
        {
            var isMinuteEven = DateTime.Now.Minute % 2;
            if (isMinuteEven == 0)
            {
                Notification();
            }
            return null;
        }
    }
}