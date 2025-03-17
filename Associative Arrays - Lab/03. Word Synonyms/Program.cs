int n = int.Parse(Console.ReadLine());
Dictionary<string, List<string>> synonyms = new();

for (int i = 0; i < n; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (!synonyms.ContainsKey(word))
    {
        synonyms.Add(word, new List<string> { synonym });
    }
    else
    {
        synonyms[word].Add(synonym);
    }
}

foreach (var pair in synonyms)
{
    Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
}