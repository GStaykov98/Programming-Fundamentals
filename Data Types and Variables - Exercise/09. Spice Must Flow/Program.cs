int yield = int.Parse(Console.ReadLine());
int storage = 0;
int daysMined = 0;

while (yield >= 100)
{
    daysMined++;
    storage += yield;
    yield -= 10;
    storage -= 26;
}

if (storage >= 26)
{
    storage -= 26;
}

Console.WriteLine(daysMined);
Console.WriteLine(storage);