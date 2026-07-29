using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Live_Chat_Application
{
    class Program
    {
        private static void Messages_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine($"New message received: {e.NewItems[0]}");
            }
        }

        static void Main()
        {
            ObservableCollection<string> messages = new ObservableCollection<string>();

            messages.CollectionChanged += Messages_CollectionChanged;

            messages.Add("Ahmed: Hello everyone!");
            messages.Add("Sara: Hi Ahmed!");
            messages.Add("Omar: Welcome to the chat.");

            Console.ReadKey();
        }
    }
}
