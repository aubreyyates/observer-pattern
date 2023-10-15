namespace ObserverPattern
{
    /// <summary>
    /// The Observer interface provides a way to receive updates from some Subject.
    /// </summary>
    public interface Observer
    {
        /// <summary>
        /// Notifies the Observer of an update.
        /// </summary>
        public void Update();
    }
}
