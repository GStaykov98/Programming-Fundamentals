int lostGames = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice  = double.Parse(Console.ReadLine());

int headsetsBroken = 0;
int mousesBroken = 0;
int keyboardsBroken = 0;
int displaysBroken = 0;

for (int i = 1; i <= lostGames; i++)
{
	if (i % 2 == 0)
	{
		headsetsBroken++;
	}

	if (i % 3 == 0)
	{
		mousesBroken++;
	}

	if (i % 2 == 0 && i % 3 == 0)
	{
		keyboardsBroken++;

		if (keyboardsBroken % 2 == 0)
		{
			displaysBroken++;
		}
	}
}

double rageExpenses = (headsetsBroken * headsetPrice) + (mousePrice * mousesBroken) + (keyboardPrice * keyboardsBroken) + (displayPrice * displaysBroken);

Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");