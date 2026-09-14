using System;

namespace Store_and_Compare_Employee_Details
{
    class Program
    {
        private static string CompareEmployees(
            (string name, decimal salary) employee1,
            (string name, decimal salary) employee2)
        {
            if (employee1.salary == employee2.salary)
            {
                return $"{employee1.name} and {employee2.name} have the same salary.";
            }
            else
            {
                return $"{employee1.name} has a {(employee1.salary > employee2.salary ? "higher" : "lower")} salary than {employee2.name}";
            }
        }

        static void Main()
        {
            (string name, decimal salary) employee1 = ("Ahmed", 15000m);
            (string name, decimal salary) employee2 = ("Sara", 12000m);

            var result = CompareEmployees(employee1, employee2);
            Console.WriteLine(result);


            Console.ReadKey();
        }
    }
}
