using System;
using System.Collections.Generic;

namespace Store_Retrieve_Student_Grades
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {
                { "Alice", 85 },
                { "Bob", 90 },
                { "Charlie", 78 },
                { "David", 92 }
            };

            Console.WriteLine($"Student: Bob, Grade: {studentGrades["Bob"]}");
            Console.WriteLine();
            foreach (var student in studentGrades)
            {
                Console.WriteLine($"Student: {student.Key}, Grade: {student.Value}");
            }



            Console.ReadKey();
        }
    }
}
