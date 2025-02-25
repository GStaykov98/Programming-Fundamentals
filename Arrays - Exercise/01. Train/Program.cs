int n = int.Parse(Console.ReadLine());
int[] wagons = new int[n];
int totalPeople = 0;

for (int i = 0; i < n; i++)
{
    int currentPeople = int.Parse(Console.ReadLine());
    totalPeople += currentPeople;
    wagons[i] = currentPeople;
}

foreach (int wagon in wagons)
{
    Console.Write($"{wagon} ");
}

Console.WriteLine();
Console.WriteLine(totalPeople);