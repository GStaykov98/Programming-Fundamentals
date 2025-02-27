double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double area = GetArea(a, b);
Console.WriteLine(area);

static double GetArea(double a, double b)
{
    return a * b;
}