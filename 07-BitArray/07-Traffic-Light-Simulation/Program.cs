using System;
using System.Collections;

namespace Traffic_Light_Simulation
{
    class Program
    {
        private static void SetTrafficLight(BitArray trafficLights, int intersectionNumber, string lightColor)
        {
            if (trafficLights == null || intersectionNumber < 1 || intersectionNumber > 3)
            {
                return;
            }

            int startIndex = (intersectionNumber - 1) * 3;

            // Turn off all lights for this intersection
            trafficLights[startIndex] = false;       // Red
            trafficLights[startIndex + 1] = false;   // Yellow
            trafficLights[startIndex + 2] = false;   // Green

            switch (lightColor.ToLower())
            {
                case "red":
                    trafficLights[startIndex] = true;
                    break;

                case "yellow":
                    trafficLights[startIndex + 1] = true;
                    break;

                case "green":
                    trafficLights[startIndex + 2] = true;
                    break;

                default:
                    Console.WriteLine($"Invalid light color: {lightColor}");
                    break;
            }
        }

        private static void DisplayTrafficLights(BitArray trafficLights)
        {
            if (trafficLights == null || trafficLights.Length != 9)
            {
                return;
            }

            for (int i = 0; i < 3; i++)
            {
                int startIndex = i * 3;

                string currentLight;

                if (trafficLights[startIndex])
                    currentLight = "Red";
                else if (trafficLights[startIndex + 1])
                    currentLight = "Yellow";
                else if (trafficLights[startIndex + 2])
                    currentLight = "Green";
                else
                    currentLight = "Off";

                Console.WriteLine($"Intersection {i + 1}: {currentLight}");
            }
        }

        static void Main()
        {
            BitArray trafficLights = new BitArray(9);

            // Intersection 1: Green
            trafficLights[2] = true;

            Console.WriteLine("Before changing:");
            Console.WriteLine(
                $"Red: {trafficLights[0]}, " +
                $"Yellow: {trafficLights[1]}, " +
                $"Green: {trafficLights[2]}");

            // Change Intersection 1 from Green to Yellow
            trafficLights[2] = false;
            trafficLights[1] = true;

            Console.WriteLine();
            Console.WriteLine("After changing:");
            Console.WriteLine(
                $"Red: {trafficLights[0]}, " +
                $"Yellow: {trafficLights[1]}, " +
                $"Green: {trafficLights[2]}");

            Console.ReadKey();
        }
    }
}
