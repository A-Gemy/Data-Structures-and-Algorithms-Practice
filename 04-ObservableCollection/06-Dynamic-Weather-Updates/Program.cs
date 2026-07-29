using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Dynamic_Weather_Updates
{
    class Program
    {
        private static void WeatherUpdates_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine($"Weather update: {e.NewItems[0]}");
            }
        }
        static void Main()
        {
            ObservableCollection<string> weatherUpdates = new ObservableCollection<string>();

            weatherUpdates.CollectionChanged += WeatherUpdates_CollectionChanged;

            weatherUpdates.Add("Cairo: 32°C Sunny");
            weatherUpdates.Add("Alexandria: 28°C Cloudy");
            weatherUpdates.Add("New York: 25°C Sunny");
            weatherUpdates.Add("London: 15°C Rainy");
            weatherUpdates.Add("Mansoura: 30°C Clear");


            Console.ReadKey();
        }
    }
}
