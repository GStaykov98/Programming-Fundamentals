string username = Console.ReadLine();

for (int i = 0; i < 4; i++)
{
    string password = Console.ReadLine();

	if (password == new string(username.Reverse().ToArray()))
	{
        Console.WriteLine($"User {username} logged in.");
        return;
    }

    if (i == 3)
    {
        Console.WriteLine($"User {username} blocked!");
    }
    else
    {
        Console.WriteLine("Incorrect password. Try again.");
    }
}