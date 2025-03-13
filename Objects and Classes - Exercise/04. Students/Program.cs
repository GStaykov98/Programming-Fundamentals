int n = int.Parse(Console.ReadLine());
List<Student> students = new();

for (int i = 0; i < n; i++)
{
    string[] studentInfo = Console.ReadLine().Split();
    string firstName = studentInfo[0];
    string lastName = studentInfo[1];
    double grade = double.Parse(studentInfo[2]);

    Student currentStudent = new(firstName, lastName, grade);
    students.Add(currentStudent);
}

students = students.OrderByDescending(x => x.Grade).ToList();

foreach (Student student in students)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
}

public class Student
{
    public Student(string firstName, string lastName, double grade)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Grade = grade;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }

}