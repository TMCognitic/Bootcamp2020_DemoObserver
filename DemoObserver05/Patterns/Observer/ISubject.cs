using System;

namespace DemoObserver.Patterns.Observer
{
    interface ISubject
    {
        event Action<ISubject> Handler;
    }
}