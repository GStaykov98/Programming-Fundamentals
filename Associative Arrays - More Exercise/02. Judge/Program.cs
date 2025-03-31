Dictionary<string, Dictionary<string, int>> studentsAndContests = new();
Dictionary<string, int> studentsPoints = new();
string input;

while ((input = Console.ReadLine()) != "no more time")
{
    string[] tokens = input.Split(" -> ");
    string student = tokens[0];
    string contest = tokens[1];
    int points = int.Parse(tokens[2]);

    if (!studentsAndContests.ContainsKey(contest))
    {
        studentsAndContests.Add(contest, new Dictionary<string, int>());
        studentsAndContests[contest].Add(student, points);
    }
    else
    {
        if (!studentsAndContests[contest].ContainsKey(student))
        {
            studentsAndContests[contest].Add(student, points);
        }
        else
        {
            if (studentsAndContests[contest][student] < points)
            {
                studentsAndContests[contest][student] = points;
            }
        }
    }

    if (!studentsPoints.ContainsKey(student))
    {
        studentsPoints.Add(student, 0);
    }
}


foreach (var contest in studentsAndContests)
{
    Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
    int counter = 1;

    foreach (var student in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
    {
        Console.WriteLine($"{counter}. {student.Key} <::> {student.Value}");
        counter++;

        studentsPoints[student.Key] += student.Value;
    }
}

int n = 1;
Console.WriteLine("Individual standings:");

foreach (var student in studentsPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{n}. {student.Key} -> {student.Value}");
    n++;
}