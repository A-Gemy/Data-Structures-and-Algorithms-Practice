using System;
using System.Collections.Generic;

namespace Ticketing_System_Simulation
{

    class TicketingSystem
    {
        private readonly Queue<int> tickets = new Queue<int>();

        private int nextTicketNumber = 101;

        public int Count => tickets.Count;


        private void PrintRemainingTickets()
        {
            if (tickets.Count > 0)
                Console.WriteLine("Remaining Tickets: " + string.Join(", ", tickets));
            else
                Console.WriteLine("No more tickets in the queue.");
        }

        public void IssueTicket()
        {
            tickets.Enqueue(nextTicketNumber);
            Console.WriteLine($"Ticket {nextTicketNumber} issued.");
            nextTicketNumber++;
        }

        public void ServeNextTicket()
        {
            if (tickets.Count == 0)
            {
                Console.WriteLine("\nNo more tickets in the queue.");
                return;
            }

            int ticket = tickets.Dequeue();
            Console.WriteLine($"\nProcessing Ticket: {ticket}");
            PrintRemainingTickets();
        }

    }

    class Program
    {
        static void Main()
        {
            TicketingSystem ts = new TicketingSystem();

            ts.IssueTicket();
            ts.IssueTicket();
            ts.IssueTicket();
            ts.IssueTicket();
            ts.IssueTicket();


            Console.WriteLine("\nTicketing System Simulation Started...");

            while (ts.Count > 0)
            {
                ts.ServeNextTicket();
            }

            ts.ServeNextTicket();

            Console.WriteLine("\nTicketing System Simulation Ended.");

            Console.ReadKey();
        }
    }
}


