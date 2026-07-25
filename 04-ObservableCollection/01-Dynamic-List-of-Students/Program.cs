using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Dynamic_List_of_Students
{
    class Program
    {
        private static void Students_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine($"Student added: {e.NewItems[0]}");
                    break;

                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine($"Student removed: {e.OldItems[0]}");
                    break;

                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine($"Student replaced: {e.OldItems[0]} with {e.NewItems[0]}");
                    break;

                case NotifyCollectionChangedAction.Move:
                    Console.WriteLine($"Student moved: {e.OldItems[0]} from index {e.OldStartingIndex} to {e.NewStartingIndex}");
                    break;

                case NotifyCollectionChangedAction.Reset:
                    Console.WriteLine("Student list reset.");
                    break;
            }
        }

        static void Main()
        {
            ObservableCollection<string> students = new ObservableCollection<string>();

            students.CollectionChanged += Students_CollectionChanged;

            students.Add("Ahmed");
            students.Add("Sara");
            students.Remove("Ahmed");
            students[0] = "Omar";
            students.Add("Laila");
            students.Add("Samir");
            students.Move(0, 2);

            Console.WriteLine();
            foreach (var student in students)
            {
                Console.WriteLine($"Current student: {student}");
            }
            Console.WriteLine();

            students.Clear();


            Console.ReadKey();
        }
    }
}
