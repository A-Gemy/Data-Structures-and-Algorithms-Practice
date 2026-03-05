using System;
using System.Collections.Generic;

namespace Traffic_Signal_System_Simulation
{
    class Traffic
    {
        private readonly Queue<string> trafficQueue = new Queue<string>();

        public int Count => trafficQueue.Count;


        private void PrintRemainingVehicles()
        {
            if (trafficQueue.Count > 0)
                Console.WriteLine("Vehicles waiting: " + string.Join(", ", trafficQueue));
            else
                Console.WriteLine("No vehicles waiting.");
        }

        public void AddVehicle(string vehicle)
        {
            trafficQueue.Enqueue(vehicle);
        }

        public void ProcessNextVehicle()
        {
            if (trafficQueue.Count == 0)
            {
                Console.WriteLine("\nNo vehicles waiting.");
                return;
            }

            string vehicle = trafficQueue.Dequeue();
            Console.WriteLine($"\n{vehicle} has passed the signal.");
            PrintRemainingVehicles();
        }

    }

    class Program
    {
        static void Main()
        {
            Traffic traffic = new Traffic();

            traffic.AddVehicle("Car 1");
            traffic.AddVehicle("Truck 1");
            traffic.AddVehicle("Bike 1");
            traffic.AddVehicle("Bus 1");

            Console.WriteLine("Traffic Signal Simulation Started...");

            while (traffic.Count > 0)
            {
                traffic.ProcessNextVehicle();
            }

            Console.WriteLine("\nTraffic Signal Simulation Ended.");

            Console.ReadKey();
        }
    }
}
