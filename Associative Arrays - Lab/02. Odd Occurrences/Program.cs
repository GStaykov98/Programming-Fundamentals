string[] input = Console.ReadLine().Split();
Dictionary<string, int> keyValuePairs = new();

foreach (string element in input)
{
    if (keyValuePairs.ContainsKey(element.ToLower()))
    {
        keyValuePairs[element.ToLower()]++;
    }
    else
    {
        keyValuePairs.Add(element.ToLower(), 1);
    }
}

foreach (var pair in keyValuePairs.Where(x => x.Value % 2 != 0))
{
    Console.Write($"{pair.Key} ");
}