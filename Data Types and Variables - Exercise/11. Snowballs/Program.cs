int snowballs = int.Parse(Console.ReadLine());
int bestSnowballSnow = 0;
int bestSnowballTime = 0;
int bestSnowballQuality = 0;
double bestSnowballValue = 0;

for (int i = 0; i < snowballs; i++)
{
    int currentSnowballSnow = int.Parse(Console.ReadLine());
    int currentSnowballTime = int.Parse(Console.ReadLine());
    int currentSnowballQuality = int.Parse(Console.ReadLine());

    double currentSnowballValue = Math.Pow((double)(currentSnowballSnow / currentSnowballTime), currentSnowballQuality);

    if (currentSnowballValue >= bestSnowballValue)
    {
        bestSnowballSnow = currentSnowballSnow;
        bestSnowballTime = currentSnowballTime;
        bestSnowballQuality = currentSnowballQuality;
        bestSnowballValue = currentSnowballValue;
    }
}

Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");