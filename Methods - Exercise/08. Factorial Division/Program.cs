int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
double firstNumFactorial = GetFactorial(n1);
double secondNumFactorial = GetFactorial(n2);
double division = GetDivision(firstNumFactorial, secondNumFactorial);
Console.WriteLine($"{division:f2}");


static double GetFactorial(int n)
{
    double result = 1.0;

    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }

    return result;
}

static double GetDivision(double n1, double n2)
{
    return n1 / n2;
}