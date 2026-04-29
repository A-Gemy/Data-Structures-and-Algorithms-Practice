using System;
using System.Collections.Generic;

namespace Dynamic_Skill_Matching
{
    class Program
    {
        static void Main()
        {
            HashSet<string> candidateSkills = new HashSet<string> { "C#", "SQL", "JavaScript" };
            HashSet<string> jobRequirements = new HashSet<string> { "C#", "JavaScript", "React" };

            HashSet<string> matchingSkills = new HashSet<string>(candidateSkills);
            matchingSkills.IntersectWith(jobRequirements);

            Console.WriteLine($"Matching Skills: " + string.Join(", ", matchingSkills));


            Console.ReadKey();
        }
    }
}
