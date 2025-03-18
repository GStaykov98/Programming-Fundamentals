int n = int.Parse(Console.ReadLine());
Dictionary<string, double[]> students = new();

for (int i = 0; i < n; i++)
{
    string currentStudent = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(currentStudent))
    {
        students.Add(currentStudent, new double[2]);
    }

    students[currentStudent][0] += grade;
    students[currentStudent][1]++;
}

foreach (var student in students)
{
    student.Value[0] = student.Value[0] / student.Value[1];

    if (student.Value[0] >= 4.5)
    {
        Console.WriteLine($"{student.Key} -> {student.Value[0]:f2}");
    }
}