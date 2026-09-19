using System;
using System.Collections;

namespace Password_Policy_Enforcement
{
    class Program
    {
        private static BitArray CheckPasswordRules(string password)
        {
            BitArray rules = new BitArray(4);

            if (string.IsNullOrEmpty(password))
                return rules;

            foreach (var ch in password)
            {
                if (char.IsUpper(ch))
                    rules[0] = true;

                if (char.IsLower(ch))
                    rules[1] = true;

                if (char.IsDigit(ch))
                    rules[2] = true;

                if (!char.IsLetterOrDigit(ch))
                    rules[3] = true;

                if (rules[0] && rules[1] && rules[2] && rules[3])
                    break;
            }

            return rules;
        }

        private static bool MeetsPasswordPolicy(BitArray checks)
        {
            if (checks == null || checks.Length == 0)
                return false;

            for (int i = 0; i < checks.Length; i++)
            {
                if (!checks[i])
                    return false;
            }

            return true;
        }

        static void Main()
        {
            string password = "Ahmed123@";

            var checks = CheckPasswordRules(password);

            Console.WriteLine($"Password meets policy: {(MeetsPasswordPolicy(checks) ? "True" : "False")}");


            Console.ReadKey();
        }
    }
}
