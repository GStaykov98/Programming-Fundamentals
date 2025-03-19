double firstX1 = double.Parse(Console.ReadLine());
double firstY1 = double.Parse(Console.ReadLine());
double firstX2 = double.Parse(Console.ReadLine());
double firstY2 = double.Parse(Console.ReadLine());

double secondX1 = double.Parse(Console.ReadLine());
double secondY1 = double.Parse(Console.ReadLine());
double secondX2 = double.Parse(Console.ReadLine());
double secondY2 = double.Parse(Console.ReadLine());

double firstLine = LongerLineResult(firstX1, firstX2, firstY1, firstY2);
double secondLine = LongerLineResult(secondX1, secondX2, secondY1, secondY2);

if (firstLine >= secondLine)
{
    double firstSmallerLine = FindPointResult(firstX1, firstY1);
    double secondSmallerLine = FindPointResult(firstX2, firstY2);

    if (firstSmallerLine <= secondSmallerLine)
    {
        Console.WriteLine($"({firstX1}, {firstY1})({firstX2}, {firstY2})");
    }
    else
    {
        Console.WriteLine($"({firstX2}, {firstY2})({firstX1}, {firstY1})");
    }
}
else
{
    double firstSmallerLine = FindPointResult(secondX1, secondY1);
    double secondSmallerLine = FindPointResult(secondX2, secondY2);

    if (firstSmallerLine <= secondSmallerLine)
    {
        Console.WriteLine($"({secondX1}, {secondY1})({secondX2}, {secondY2})");
    }
    else
    {
        Console.WriteLine($"({secondX2}, {secondY2})({secondX1}, {secondY1})");
    }
}


static double FindPointResult(double x1, double y1)
{
    return Math.Abs(x1) + Math.Abs(y1);
}

static double LongerLineResult(double x1, double y1, double x2, double y2)
{
    return Math.Abs(x1) + Math.Abs(y1) + Math.Abs(x2) + Math.Abs(y2);
}