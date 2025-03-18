string input = Console.ReadLine();
Dictionary<char, int> occurrences = new();

for (int i = 0; i < input.Length; i++)
{
	char currentChar = input[i];

	if (currentChar != ' ')
	{
		if (occurrences.ContainsKey(currentChar))
		{
			occurrences[currentChar]++;
		}
        else
        {
			occurrences.Add(currentChar, 1);
        }
    }
}

foreach (var pair in occurrences)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}