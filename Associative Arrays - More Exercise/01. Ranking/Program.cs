Dictionary<string, string> contests = new();
Dictionary<string, Dictionary<string, int>> students = new();
string input;

while ((input = Console.ReadLine()) != "end of contests")
{
    string[] tokens = input.Split(':');
    string contestName = tokens[0];
    string contestPassword = tokens[1];

    contests.Add(contestName, contestPassword);
}

while ((input = Console.ReadLine()) != "end of submissions")
{
    string[] tokens = input.Split("=>");
    string contestName = tokens[0];
    string contestPassword = tokens[1];
    string student = tokens[2];
    int points = int.Parse(tokens[3]);

    if (contests.ContainsKey(contestName))
    {
        if (contests[contestName] == contestPassword)
        {
            if (!students.ContainsKey(student))
            {
                students.Add(student, new Dictionary<string, int>());
                students[student].Add(contestName, points);
            }
            else
            {
                if (!students[student].ContainsKey(contestName))
                {
                    students[student].Add(contestName, points);
                }
                else
                {
                    if (students[student][contestName] < points)
                    {
                        students[student][contestName] = points;
                    }
                }
            }
        }
    }
}

string bestStudent = string.Empty;
int mostPoints = 0;

foreach (var student in students)
{
    int currentPoints = 0;

    foreach (var contest in student.Value)
    {
        currentPoints += contest.Value;
    }

    if (currentPoints > mostPoints)
    {
        bestStudent = student.Key;
        mostPoints = currentPoints;
    }
}

Console.WriteLine($"Best candidate is {bestStudent} with total {mostPoints} points.");
Console.WriteLine("Ranking:");

foreach (var student in students.OrderBy(x => x.Key))
{
    Console.WriteLine(student.Key);

    foreach (var contest in student.Value.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
    }
}