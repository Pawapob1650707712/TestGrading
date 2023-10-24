using System.ComponentModel.Design;

namespace TestGrading
{
    public class Grading
    {
        public static string GradeCalculator(int score)
        {
            if (score < 0 || score > 100)
                return "Invalid";


            else if (score >= 80 && score <= 100)
                return "A";
            else if (score >= 70)
                return "B";
            else if (score >= 60)
                return "C";
            else if (score >= 50)
                return "D";
            else if (score >= 0)
                return "F";
            else
                return ("Error");
        }

        public static void PrintOut(int score)
        {
            string grade = GradeCalculator(score);
            if (grade != "Invalid")
                Console.WriteLine("Grade is " + grade);
            else
            {
                if (score < 0)
                    Console.WriteLine("Error: Score is lower than zero");
                else
                    Console.WriteLine("Error: Score is higher than 100");
            }
        }
    }
}