using System;
using System.Collections.Generic;

namespace Printer_Job_Scheduling
{
    class Job
    {
        public int JobId { get; set; }
        public string DocumentName { get; set; }
        public int Pages { get; set; }

        public Job(int jobId, string documentName, int pages)
        {
            JobId = jobId;
            DocumentName = documentName;
            Pages = pages;
        }

        public override string ToString()
        {
            return $"JobId: {JobId} | Document: {DocumentName} | Pages: {Pages}";
        }

    }

    class Printer
    {
        private readonly Queue<Job> printQueue = new Queue<Job>();

        public void AddJob(int jobId, string documentName, int pages)
        {
            printQueue.Enqueue(new Job(jobId, documentName, pages));
        }

        public void PrintNextJob()
        {
            if (printQueue.Count == 0)
            {
                Console.WriteLine("No jobs in queue");
                return;
            }
            Job job = printQueue.Dequeue();
            Console.WriteLine($"Printing: {job}");
            Console.WriteLine($"Remaining jobs: {printQueue.Count}\n");
        }

        public void ShowNextJob()
        {
            if (printQueue.Count == 0)
            {
                Console.WriteLine("No jobs in queue");
                return;
            }

            Job job = printQueue.Peek();
            Console.WriteLine($"Next: {job}");
        }

    }

    class Program
    {
        static void Main()
        {
            Printer printer = new Printer();

            // Add jobs
            printer.AddJob(1, "Report.pdf", 6);
            printer.AddJob(2, "Image.png", 2);
            printer.AddJob(3, "Notes.txt", 4);

            printer.ShowNextJob();

            Console.WriteLine("\nPrinting jobs...\n");
            printer.PrintNextJob();
            printer.PrintNextJob();
            printer.PrintNextJob();

            Console.WriteLine("Trying to print when queue is empty:");
            printer.PrintNextJob();



            Console.ReadKey();
        }
    }
}
