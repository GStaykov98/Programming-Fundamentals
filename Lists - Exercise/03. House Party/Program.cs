int n = int.Parse(Console.ReadLine());
List<string> guests = new();

for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split();
    string guestName = command[0];

    if (!command.Contains("not"))
	{
		if (guests.Contains(guestName))
		{
            Console.WriteLine($"{guestName} is already in the list!");
        }
        else
        {
            guests.Add(guestName);
        }
    }
    else
    {
        if (guests.Contains(guestName))
        {
            guests.Remove(guestName);
        }
        else
        {
            Console.WriteLine($"{guestName} is not in the list!");
        }
    }
}

foreach (var guest in guests)
{
    Console.WriteLine(guest);
}