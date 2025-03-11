List<Student> students = new();
string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] inputArr = input.Split();

    string firstName = inputArr[0];
    string lastName = inputArr[1];
    int age = int.Parse(inputArr[2]);
    string homeTown = inputArr[3];

    Student currentStudent = new Student
    {
        FirstName = firstName,
        LastName = lastName,
        Age = age,
        HomeTown = homeTown
    };

    if (IsStudentExisting(students, firstName, lastName))
    {
        Student studentToChange = students.Find(f => f.FirstName == firstName && f.LastName == lastName);
        studentToChange.Age = age;
        studentToChange.HomeTown = homeTown;
    }
    else
    {
        students.Add(currentStudent);
    }
}

string town = Console.ReadLine();

foreach (var student in students.Where(x => x.HomeTown == town))
{
    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
}

static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
{
    foreach (var student in students)
    {
        if (student.FirstName == firstName && student.LastName == lastName)
        {
            return true;
        }
    }

    return false;
}

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}