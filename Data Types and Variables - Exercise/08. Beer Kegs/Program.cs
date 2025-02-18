int n = int.Parse(Console.ReadLine());
string biggestKegName = string.Empty;
double biggestKegCapacity = 0;

for (int i = 0; i < n; i++)
{
    string model = Console.ReadLine();
    float radius = float.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    double currentKegCapacity = Math.PI * Math.Pow(radius, 2) * height;

    if (currentKegCapacity > biggestKegCapacity)
    {
        biggestKegName = model;
        biggestKegCapacity = currentKegCapacity;
    }
}

Console.WriteLine(biggestKegName);