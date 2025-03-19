int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
bool isPositive = true;

if (!IsNumberPositive(n1))
{
    isPositive = ChangeResult(isPositive);
}

if (!IsNumberPositive(n2))
{
    isPositive = ChangeResult(isPositive);
}

if (!IsNumberPositive(n3))
{
    isPositive = ChangeResult(isPositive);
}

if (IsNumberZero(n1, n2, n3))
{
    Console.WriteLine("zero");
}
else
{
    if (isPositive)
    {
        Console.WriteLine("positive");
    }
    else if (!isPositive)
    {
        Console.WriteLine("negative");
    }
}


static bool IsNumberPositive(int number)
{
    return number > 0;
}

static bool ChangeResult(bool currentResult)
{
    if (currentResult)
    {
        return false;
    }
    else
    {
        return true;
    }
}

static bool IsNumberZero(int n1, int n2, int n3)
{
    if (n1 == 0 ||
        n2 == 0 ||
        n3 == 0)
    {
        return true;
    }
     
    return false;
}