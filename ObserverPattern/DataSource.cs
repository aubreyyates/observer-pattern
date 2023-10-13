namespace ObserverPattern
{
    public class DataSource : Subject
    {
        private int Value;

        public int GetValue()
        {
            return Value;
        }

        public void SetValue(int value)
        {
            Value = value;
            NotifyOberservers();
        }
    }
}
