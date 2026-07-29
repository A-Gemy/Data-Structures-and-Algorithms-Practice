using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Real_Time_Stock_Prices
{
    class Program
    {
        private static void StockPrices_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine($"New Stock Price Added: {e.NewItems[0]}");
            }
        }

        static void Main()
        {
            ObservableCollection<string> stockPrices = new ObservableCollection<string>();

            stockPrices.CollectionChanged += StockPrices_CollectionChanged;

            stockPrices.Add("AAPL: 150.00");
            stockPrices.Add("MSFT: 240.50");
            stockPrices.Add("GOOGL: 2800.75");


            Console.ReadKey();
        }
    }
}
