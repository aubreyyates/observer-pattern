namespace ObserverPattern.Observers
{
    /// <summary>
    /// The Spreadsheet class represents a chart of data. It observes the DataSource.
    /// </summary>
    public class Chart : Observer
    {
        /// <summary>
        /// The DataSource.
        /// </summary>
        private readonly DataSource _dataSource;

        /// <summary>
        /// The constructor sets the DataSource.
        /// </summary>
        /// <param name="dataSource">The DataSource.</param>
        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        /// <summary>
        /// Updates the chart based on changes in the DataSource.
        /// </summary>
        public void Update()
        {
            Console.WriteLine("Chart value updated: " + _dataSource.GetValue());
        }
    }
}
