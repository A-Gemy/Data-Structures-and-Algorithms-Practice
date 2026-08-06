using System;

namespace Survey_Responses
{
    class Program
    {
        private static void DisplaySurveyResponses(string[][] surveyResponses)
        {
            if (surveyResponses == null || surveyResponses.Length == 0)
            {
                Console.WriteLine("No survey responses available.");
                return;
            }

            for (int i = 0; i < surveyResponses.Length; i++)
            {
                if (surveyResponses[i] == null || surveyResponses[i].Length == 0)
                {
                    Console.WriteLine($"Respondent {i + 1} has no responses.");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine($"Respondent {i + 1} responses:");

                for (int j = 0; j < surveyResponses[i].Length; j++)
                {
                    Console.WriteLine($" - Question {j + 1}: {surveyResponses[i][j]}");
                }

                Console.WriteLine();
            }
        }

        static void Main()
        {
            string[][] surveyResponses =
            {
                new string[] { "Yes", "No", "Yes" },
                new string[] { "No", "Yes" },
                new string[] { "Yes", "Yes", "No", "Yes" }
            };

            DisplaySurveyResponses(surveyResponses);


            Console.ReadKey();
        }
    }
}
