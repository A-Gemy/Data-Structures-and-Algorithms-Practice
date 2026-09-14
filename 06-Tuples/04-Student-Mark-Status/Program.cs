using System;

namespace Student_Mark_Status
{
    class Program
    {
        private static (bool isSuccess, int mark) CheckStudentMark(int mark)
        {
            bool isSuccess = mark >= 50;

            return (isSuccess, mark);
        }

        static void Main()
        {
            var result = CheckStudentMark(75);

            Console.WriteLine($"Success: {result.isSuccess}");
            Console.WriteLine($"Mark: {result.mark}");


            Console.ReadKey();
        }
    }
}
