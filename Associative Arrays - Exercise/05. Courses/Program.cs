Dictionary<string, List<string>> courses = new();
string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] tokens = input.Split(" : ");
    string currentCourse = tokens[0];
    string student = tokens[1];

    if (!courses.ContainsKey(currentCourse))
    {
        courses.Add(currentCourse, new List<string>());
    }

    courses[currentCourse].Add(student);
}

foreach (var course in courses)
{
    Console.WriteLine($"{course.Key}: {course.Value.Count}");

    foreach (var student in course.Value)
    {
        Console.WriteLine($"-- {student}");
    }
}