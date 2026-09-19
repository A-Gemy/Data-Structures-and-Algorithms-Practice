using System;
using System.Collections;

namespace Password_Strength_Checker
{
    class Program
    {
        private static BitArray CheckPasswordStrength(string password)
        {
            BitArray checks = new BitArray(4);

            foreach(var ch in password)
            {
                if (char.IsUpper(ch))
                    checks[0] = true;
                
                if (char.IsLower(ch))
                    checks[1] = true;
                
                if (char.IsDigit(ch))
                    checks[2] = true;
                
                if (!char.IsLetterOrDigit(ch))
                    checks[3] = true;

                if (checks[0] && checks[1] && checks[2] && checks[3])
                    break;
            }

            return checks;
        }

        private static void DisplayPasswordStrength(BitArray checks)
        {
            Console.WriteLine($"Has uppercase: {(checks[0] ? "Yes": "No")}");
            Console.WriteLine($"Has lowercase: {(checks[1] ? "Yes": "No")}");
            Console.WriteLine($"Has digit: {(checks[2] ? "Yes": "No")}");
            Console.WriteLine($"Has special character: {(checks[3] ? "Yes": "No")}");
        }

        static void Main()
        {
            string password = "Ahmed123@";

            var checks = CheckPasswordStrength(password);

            DisplayPasswordStrength(checks);


            Console.ReadKey();
        }
    }
}
