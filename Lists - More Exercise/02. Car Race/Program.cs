List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
double leftCarTime = 0;
double rightCarTime = 0;
int steps = numbers.Count / 2;

for (int i = 0; i < steps; i++)
{
    leftCarTime += numbers[i];

	if (numbers[i] == 0)
	{
		leftCarTime -= leftCarTime * 0.2;
	}
}

for (int i = numbers.Count - 1; i >= 0; i--)
{
    if (i == steps)
    {
        break;
    }

    rightCarTime += numbers[i];

    if (numbers[i] == 0)
    {
        rightCarTime -= rightCarTime * 0.2;
    }
}

if (leftCarTime > rightCarTime)
{
    Console.WriteLine($"The winner is right with total time: {rightCarTime}");
}
else
{
    Console.WriteLine($"The winner is left with total time: {leftCarTime}");
}