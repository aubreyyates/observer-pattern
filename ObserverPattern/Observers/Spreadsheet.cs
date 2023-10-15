namespace ObserverPattern.Observers
{
    /// <summary>
    /// The Spreadsheet class represents a spreadsheet of data. It observes the DataSource.
    /// </summary>
    public class Spreadsheet : Observer
    {
        /// <summary>
        /// The DataSource.
        /// </summary>
        private readonly DataSource _dataSource;

        /// <summary>
        /// The constructor sets the DataSource.
        /// </summary>
        /// <param name="dataSource">The DataSource.</param>
        public Spreadsheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        /// <summary>
        /// Updates the sheet based on changes in the DataSource.
        /// </summary>
        public void Update()
        {
            Console.WriteLine("Spreadsheet value updated: " +  _dataSource.GetValue());
        }
    }
}
