namespace ObserverPattern
{
    /// <summary>
    /// The Subject class is a class that can be observered. When value updates happen, observers should be notified.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// The list of Observers.
        /// </summary>
        private List<Observer> Observers = new List<Observer>();

        /// <summary>
        /// Adds an Observer to the list of Observers
        /// </summary>
        /// <param name="observer">The Observer to add.</param>
        public void AddObserver(Observer observer)
        {
            Observers.Add(observer);
        }

        /// <summary>
        /// Removes an Observer from the list of Observers
        /// </summary>
        /// <param name="observer">The Observer to remove.</param>
        public void RemoveObserver(Observer observer)
        {
            Observers.Remove(observer);
        }

        /// <summary>
        /// Notifies all Observers of an update.
        /// </summary>
        public void NotifyOberservers()
        {
            foreach(Observer observer in Observers)
            {
                observer.Update();
            }
        }
    }
}
