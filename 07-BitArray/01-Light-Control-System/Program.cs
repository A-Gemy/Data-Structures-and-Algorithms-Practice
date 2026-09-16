using System;
using System.Collections;

namespace Light_Control_System
{
    class Program
    {
        private static void DisplayLights(BitArray lights)
        {
            if (lights == null || lights.Length == 0)
            {
                Console.WriteLine("No lights available.");
                return;
            }

            for (int i = 0; i < lights.Length; i++)
            {
                Console.WriteLine($"Light {i + 1}: {(lights[i] ? "On" : "Off")}");
            }
        }

        static void Main()
        {
            BitArray lights = new BitArray(8);

            lights.Set(0, true); // Turn on light 1
            lights.Set(3, true); // Turn on light 4
            lights.Set(5, true); // Turn on light 6
            lights.Set(7, true); // Turn on light 8

            DisplayLights(lights);

            lights.SetAll(false); // Turn off all lights

            Console.WriteLine("\nAfter turning off all lights:");

            DisplayLights(lights);


            Console.ReadKey();
        }
    }
}
