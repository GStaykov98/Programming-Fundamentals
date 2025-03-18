int n = int.Parse(Console.ReadLine());
Dictionary<string, string> parking = new();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    string operation = input[0];
    string user = input[1];

    if (operation == "register")
    {
        string licensePlate = input[2];

        if (parking.ContainsKey(user))
        {
            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
        }
        else
        {
            parking.Add(user, licensePlate);
            Console.WriteLine($"{user} registered {licensePlate} successfully");
        }
    }
    else if (operation == "unregister")
    {
        if (!parking.ContainsKey(user))
        {
            Console.WriteLine($"ERROR: user {user} not found");
        }
        else
        {
            parking.Remove(user);
            Console.WriteLine($"{user} unregistered successfully");
        }
    }
}

foreach (var user in parking)
{
    Console.WriteLine($"{user.Key} => {user.Value}");
}