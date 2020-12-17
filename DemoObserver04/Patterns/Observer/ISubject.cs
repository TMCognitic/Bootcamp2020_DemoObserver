using System;

namespace DemoObserver.Patterns.Observer
{
    interface ISubject
    {
        void Attach(Action<ISubject> method);
        void Detach(Action<ISubject> method);
    }
}