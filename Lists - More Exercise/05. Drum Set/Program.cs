double budget = double.Parse(Console.ReadLine());
List<int> initalDrumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> currentDrumSet = new List<int>(initalDrumSet);
string input;

while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
{
    int power = int.Parse(input);

	for (int i = 0; i < currentDrumSet.Count; i++)
	{
		currentDrumSet[i] -= power;

		if (currentDrumSet[i] <= 0)
		{
			int drumPrice = initalDrumSet[i] * 3;

			if (budget >= drumPrice)
			{
				currentDrumSet[i] = initalDrumSet[i];
				budget -= drumPrice;
			}
		}
	}
}

Console.WriteLine(string.Join(" ", currentDrumSet.Where(x => x > 0)));
Console.WriteLine($"Gabsy has {budget:f2}lv.");