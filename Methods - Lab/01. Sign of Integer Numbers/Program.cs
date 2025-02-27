int n = int.Parse(Console.ReadLine());

CheckIfPositive(n);

static void CheckIfPositive(int number)
{
	if (number > 0)
	{
		Console.WriteLine($"The number {number} is positive.");
	}
	else if (number < 0)
	{
        Console.WriteLine($"The number {number} is negative.");
    }
    else
    {
        Console.WriteLine($"The number {number} is zero.");
    }
}