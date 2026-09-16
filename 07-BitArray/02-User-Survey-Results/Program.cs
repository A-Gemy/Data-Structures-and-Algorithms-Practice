using System;
using System.Collections;

namespace User_Survey_Results
{
    class Program
    {
        private static void DisplaySurveyResults(BitArray[] surveyResults)
        {
            if (surveyResults == null || surveyResults.Length == 0)
            {
                Console.WriteLine("No survey results available.");
                return;
            }

            for (int i = 0; i < surveyResults.Length; i++)
            {
                Console.WriteLine($"User {i + 1}:");

                for (int j = 0; j < surveyResults[i].Length; j++)
                {
                    Console.WriteLine($"Q{j + 1}: {(surveyResults[i][j] ? "Yes" : "No")}");
                }

                Console.WriteLine();
            }
        }

        static void Main()
        {
            BitArray[] surveyResults =
            {
                new BitArray(new bool[] { true,  false, true,  true,  false }), 
                new BitArray(new bool[] { false, true,  true,  false, true  }), 
                new BitArray(new bool[] { true,  true,  false, true,  true  }), 
                new BitArray(new bool[] { false, false, true,  false, false }), 
                new BitArray(new bool[] { true,  false, false, true,  false }), 
                new BitArray(new bool[] { true,  true,  true,  false, true  }), 
                new BitArray(new bool[] { false, true,  false, true,  false }), 
                new BitArray(new bool[] { true,  false, true,  false, true  }), 
                new BitArray(new bool[] { false, false, false, true,  true  }), 
                new BitArray(new bool[] { true,  true,  false, false, true  })  
            };

            DisplaySurveyResults(surveyResults);


            Console.ReadKey();
        }
    }
}
