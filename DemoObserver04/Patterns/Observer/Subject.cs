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

        public void Attach(Action<ISubject> method)
        {
            _handler += method;
        }

        public void Detach(Action<ISubject> method)
        {
            _handler -= method;
        }

        protected void Notify()
        {
            _handler?.Invoke(this);
        }
    }
}
