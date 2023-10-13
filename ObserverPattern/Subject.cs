namespace ObserverPattern
{
    public class Subject
    {
        private List<Observer> Observers = new List<Observer>();

        public void AddObserver(Observer observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyOberservers()
        {
            foreach(Observer observer in Observers)
            {
                observer.Update();
            }
        }
    }
}
