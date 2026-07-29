using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Real_Time_Notification_System
{
    class Program
    {
        private static void Notifications_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine($"New notification: {e.NewItems[0]}");
            }
        }

        static void Main()
        {
            ObservableCollection<string> notifications = new ObservableCollection<string>();

            notifications.CollectionChanged += Notifications_CollectionChanged;

            notifications.Add("Your order has been placed.");
            notifications.Add("Your order is being prepared.");
            notifications.Add("Your order is out for delivery.");
            notifications.Add("Your order has been delivered.");


            Console.ReadKey();
        }
    }
}
