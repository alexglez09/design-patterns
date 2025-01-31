using Observer.Observers;

namespace Observer.Subject
{
    public abstract class AbstractSubject
    {
        private readonly List<AbstractObserver> observers = new();

        public void Register(AbstractObserver observer)
        {
            this.observers.Add(observer);
        }

        public void UnRegister(AbstractObserver observer)
        {
            this.observers.Remove(observer);
        }

        protected void Notify()
        {
            foreach (var observer in this.observers)
            {
                observer.Update();
            }
        }
    }
}
