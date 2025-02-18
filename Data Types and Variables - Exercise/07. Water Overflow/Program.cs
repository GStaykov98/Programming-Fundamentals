int n = int.Parse(Console.ReadLine());
int totalLiters = 0;

for (int i = 0; i < n; i++)
{
    int currentLiters = int.Parse(Console.ReadLine());

	if (totalLiters + currentLiters > 255)
	{
        Console.WriteLine("Insufficient capacity!");
        continue;
    }

    totalLiters += currentLiters;
}

Console.WriteLine(totalLiters);