

namespace gradingApplication
{
    public class Student
    {
        public string StudentName { get; set; }
        public string Grade { get; set; }
        private const int examAssignments = 5;

        public int[] ExamScores = new int[examAssignments];
        public decimal AverageScore { get; set; }
        public Student(string name, int[] scores)
        {
            StudentName = name;
            int assignmentNumber = 0;
            decimal totalScore = 0;
            foreach (int score in scores)
            {
                if (assignmentNumber >= examAssignments)
                {
                    totalScore += score / 10;
                }
                else { totalScore += score; }
                assignmentNumber++;
            }

            AverageScore = totalScore / examAssignments;
            Grade = GetGradeLetter(AverageScore);
        }
        private string GetGradeLetter(decimal score)
        {
            if (score >= 97)
            {
                return "A+";
            }
            else if (score >= 93)
            {
                return "A";
            }
            else if (score >= 90)
            {
                return "A-";
            }
            else if (score >= 87)
            {
                return "B+";
            }
            else if (score >= 83)
            {
                return "B";
            }
            else if (score >= 80)
            {
                return "B-";
            }
            else if (score >= 77)
            {
                return "C+";
            }
            else if (score >= 73)
            {
                return "C";
            }
            else if (score >= 70)
            {
                return "C-";
            }
            else if (score >= 67)
            {
                return "D+";
            }
            else if (score >= 63)
            {
                return "D";
            }
            else if (score >= 60)
            {
                return "D-";
            }
            else
            {
                return "F";
            }
        }
    }
}