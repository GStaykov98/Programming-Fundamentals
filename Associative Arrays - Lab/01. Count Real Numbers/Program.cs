int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
SortedDictionary<int, int> keyValuePairs = new();

foreach (var num in input)
{
    if (keyValuePairs.ContainsKey(num))
    {
        keyValuePairs[num]++;
    }
    else
    {
        keyValuePairs.Add(num, 1);
    }
}

foreach (var pair in keyValuePairs)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}