using System;

namespace Return_Multiple_Values_from_a_Function
{
    class Program
    {
        private static (string name, int age, double grade) GetStudentInfo()
        {
            return ("Ahmed", 22, 95.5);
        }

        static void Main()
        {
            var student = GetStudentInfo();
            
            Console.WriteLine($"Name: {student.name}");
            Console.WriteLine($"Age: {student.age}");
            Console.WriteLine($"Grade: {student.grade}");


            Console.ReadKey();
        }
    }
}
