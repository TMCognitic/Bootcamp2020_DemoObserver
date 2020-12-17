namespace DemoObserver.Patterns.Observer
{
    interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
    }
}