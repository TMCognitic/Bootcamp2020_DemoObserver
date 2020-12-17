using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.Patterns.Observer
{
    abstract class Subject : ISubject
    {
        public event Action<ISubject> Handler;

        protected void Notify()
        {
            Handler?.Invoke(this);
        }
    }
}
