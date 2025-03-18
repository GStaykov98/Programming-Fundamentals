string input;
Dictionary<string, int> resources = new();

while ((input = Console.ReadLine()) != "stop")
{
    string resource = input;
    int quantity = int.Parse(Console.ReadLine());

    if (resources.ContainsKey(resource))
    {
        resources[resource] += quantity;
    }
    else
    {
        resources.Add(resource, quantity);
    }
}

foreach (var pair in resources)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}