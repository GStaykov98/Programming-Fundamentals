int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

PrintSmallestNumber(n1, n2, n3);

static void PrintSmallestNumber(int n1, int n2, int n3)
{
	if (n1 < n2 && n1 < n3)
	{
        Console.WriteLine(n1);
    }
	else if (n2 < n1 && n2 < n3)
	{
        Console.WriteLine(n2);
    }
	else
	{
        Console.WriteLine(n3);
    }
}