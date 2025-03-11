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

    students.Add(currentStudent);
}

string town = Console.ReadLine();

foreach (var student in students.Where(x => x.HomeTown == town))
{
    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
}

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}