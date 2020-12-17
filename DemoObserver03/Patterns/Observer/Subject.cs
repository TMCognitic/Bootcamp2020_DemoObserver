using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.Patterns.Observer
{
    abstract class Subject : ISubject
    {
        private Action<ISubject> _handler;

        public void Attach(IObserver observer)
        {
            _handler += observer.Update;
        }

        public void Detach(IObserver observer)
        {
            _handler -= observer.Update;
        }

        protected void Notify()
        {
            _handler?.Invoke(this);
        }
    }
}
