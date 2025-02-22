int power = int.Parse(Console.ReadLine());
int distance = int.Parse(Console.ReadLine());
int exhaustionFactor = int.Parse(Console.ReadLine());
int pokemonsPoked = 0;
int initialPower = power;

while (power >= distance)
{
    pokemonsPoked++;
    power -= distance;

    if ((double)initialPower / 2.0 == power)
    {
        power = power / exhaustionFactor;
    }
}

Console.WriteLine(power);
Console.WriteLine(pokemonsPoked);