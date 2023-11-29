
using gradingApplication;

List<Student> students = new List<Student>();
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

students.Add(new Student("Sophia", sophiaScores));
students.Add(new Student("Andrew", andrewScores));
students.Add(new Student("Emma", emmaScores));
students.Add(new Student("Logan", loganScores));
students.Add(new Student("Becky", beckyScores));
students.Add(new Student("Chris", chrisScores));
students.Add(new Student("Eric", ericScores));
students.Add(new Student("Gregor", gregorScores));

ReportCard();

Console.WriteLine("Press the Enter key to continue");
Console.Read();

void ReportCard()
{
    Console.WriteLine("Student\t\tGrade\n");
    foreach (Student student in students)
    {
        Console.WriteLine($"{student.StudentName}:\t\t{student.AverageScore:0.0}\t{student.Grade}");
    }
}