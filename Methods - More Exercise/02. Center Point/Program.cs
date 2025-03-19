double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());

double firstPoint = FindPointResult(x1, y1);
double secondPoint = FindPointResult(x2, y2);

if (firstPoint > secondPoint)
{
    Console.WriteLine($"({x2}, {y2})");
}
else if (firstPoint <= secondPoint)
{
    Console.WriteLine($"({x1}, {y1})");
}

static double FindPointResult(double x1, double y1)
{
    double result = Math.Abs(x1) + Math.Abs(y1);
    return result;
}