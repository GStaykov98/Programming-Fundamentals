double budget = double.Parse(Console.ReadLine());
string input;
double totalSpent = 0;

while ((input = Console.ReadLine()) != "Game Time")
{
    string gameName = input;
	double gamePrice = 0;

	switch (gameName)
	{
		case "OutFall 4":
			gamePrice = 39.99;
			break;

		case "CS: OG":
			gamePrice = 15.99;
			break;

		case "Zplinter Zell":
			gamePrice = 19.99;
			break;

		case "Honored 2":
			gamePrice = 59.99;
			break;

		case "RoverWatch":
			gamePrice = 29.99;
			break;

		case "RoverWatch Origins Edition":
			gamePrice = 39.99;
			break;

        default:
            Console.WriteLine("Not Found");
			continue;
	}

	if (gamePrice > budget)
	{
        Console.WriteLine("Too Expensive");
    }
	else
	{
        Console.WriteLine($"Bought {gameName}");
		totalSpent += gamePrice;
		budget -= gamePrice;
    }

	if (budget == 0)
	{
        Console.WriteLine("Out of money!");
		return;
    }
}

Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${budget:f2}");