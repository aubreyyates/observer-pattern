namespace ObserverPattern.Observers
{
    public class Chart : Observer
    {
        private readonly DataSource _dataSource;

        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Chart value updated: " + _dataSource.GetValue());
        }
    }
}
