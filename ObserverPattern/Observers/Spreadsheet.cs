namespace ObserverPattern.Observers
{
    public class Spreadsheet : Observer
    {
        private readonly DataSource _dataSource;

        public Spreadsheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Spreadsheet value updated: " +  _dataSource.GetValue());
        }
    }
}
