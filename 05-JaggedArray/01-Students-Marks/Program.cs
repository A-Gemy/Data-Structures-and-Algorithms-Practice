using System;

namespace Students_Marks
{
    class Program
    {
        private static void DisplayStudentMarks(int[][] studentMarks)
        {
            if (studentMarks == null || studentMarks.Length == 0)
            {
                Console.WriteLine("No student marks available.");
                return;
            }

            for (int i = 0; i < studentMarks.Length; i++)
            {
                Console.WriteLine($"Student {i + 1} marks:");

                for (int j = 0; j < studentMarks[i].Length; j++)
                {
                    Console.WriteLine($" - Subject {j + 1}: {studentMarks[i][j]}");
                }

                Console.WriteLine();
            }

            //for (int i = 0; i < studentMarks.Length; i++)
            //{
            //    Console.Write($"Student {i + 1}: [");
            //    Console.Write(string.Join(", ", studentMarks[i]));
            //    Console.WriteLine("]");
            //}
        }

        static void Main()
        {
            int[][] studentMarks =
            {
                new int[] { 90, 85, 88 },
                new int[] { 76, 80 },
                new int[] { 92, 93, 89, 85 }
            };

            DisplayStudentMarks(studentMarks);


            Console.ReadKey();
        }


    }
}
