using ObserverPattern.Observers;
using ObserverPattern;

// Instantiate a DataSource and add observers that can observe value changes in the DataSource.
DataSource dataSource = new DataSource();
dataSource.AddObserver(new Chart(dataSource));
dataSource.AddObserver(new Spreadsheet(dataSource));

// The value is changed to 50 in the DataSource. The Chart and Spreadsheet are notified about this change.
// Prints "Chart value updated: 50" on one line and "Spreadsheet value updated: 50" on the next.
dataSource.SetValue(50);

// The value is changed to 100 in the DataSource. The Chart and Spreadsheet are notified about this change.
// Prints "Chart value updated: 100" on one line and "Spreadsheet value updated: 100" on the next.
dataSource.SetValue(100);

// The value is changed to 8499 in the DataSource. The Chart and Spreadsheet are notified about this change.
// Prints "Chart value updated: 8499" on one line and "Spreadsheet value updated: 8499" on the next.
dataSource.SetValue(8499);
