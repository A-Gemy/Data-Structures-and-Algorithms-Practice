using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Task_Management_System
{
    class Program
    {
        private static void Tasks_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine($"Task added: {e.NewItems[0]}");
                    break;

                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine($"Task removed: {e.OldItems[0]}");
                    break;

                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine($"Task status updated: {e.OldItems[0]} -> {e.NewItems[0]}");
                    break;

                case NotifyCollectionChangedAction.Move:
                    Console.WriteLine($"Task moved: {e.OldItems[0]} from index {e.OldStartingIndex} to {e.NewStartingIndex}");
                    break;

                case NotifyCollectionChangedAction.Reset:
                    Console.WriteLine("Task list cleared.");
                    break;
            }
        }

        static void Main()
        {
            ObservableCollection<string> tasks = new ObservableCollection<string>();

            tasks.CollectionChanged += Tasks_CollectionChanged;

            tasks.Add("Study C# - Pending");
            tasks.Add("Finish homework - Pending");
            tasks.Add("Practice ObservableCollection - Pending");

            tasks.Remove("Study C# - Pending");

            tasks[0] = "Finish homework - Completed";

            tasks.Move(1, 0);

            Console.WriteLine();
            Console.WriteLine("Current Tasks:");

            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }

            Console.WriteLine();

            tasks.Clear();


            Console.ReadKey();
        }
    }
}
