namespace ObserverPattern
{
    /// <summary>
    /// The DataSource class contains a value. Observers need to be notified when these values change.
    /// </summary>
    public class DataSource : Subject
    {
        /// <summary>
        /// The value.
        /// </summary>
        private int Value;

        /// <summary>
        /// Returns the value.
        /// </summary>
        /// <returns>The value.</returns>
        public int GetValue()
        {
            return Value;
        }

        /// <summary>
        /// Sets the value. Notifies Observers of the change.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetValue(int value)
        {
            Value = value;
            NotifyOberservers();
        }
    }
}
