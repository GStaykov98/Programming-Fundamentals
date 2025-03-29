using System.Text.RegularExpressions;

Regex nameRegex = new Regex(@"(?<name>[A-Za-z]+)");
Regex distanceRegex = new Regex(@"(?<distance>[0-9])");
string[] racers = Console.ReadLine().Split(", ");
Dictionary<string, int> racersAndTimes = new();

foreach (string racer in racers)
{
    racersAndTimes.Add(racer, 0);
}

string input;

while ((input = Console.ReadLine()) != "end of race")
{
    MatchCollection nameMatches = nameRegex.Matches(input);
    MatchCollection distanceMatches = distanceRegex.Matches(input);
    string currentName = "";
    int currentDistance = 0;

    foreach (var match in nameMatches)
    {
        currentName += match;
    }

    foreach (var match in distanceMatches)
    {
        currentDistance += int.Parse(match.ToString());
    }

    if (racersAndTimes.ContainsKey(currentName))
    {
        racersAndTimes[currentName] += currentDistance;
    }
}

int count = 1;

foreach (var racer in racersAndTimes.OrderByDescending(x => x.Value))
{
    if (count == 1)
    {
        Console.WriteLine($"1st place: {racer.Key}");
    }
    else if (count == 2)
    {
        Console.WriteLine($"2nd place: {racer.Key}");
    }
    else if (count == 3)
    {
        Console.WriteLine($"3rd place: {racer.Key}");
    }
    else if (count == 4)
    {
        break;
    }

    count++;
}