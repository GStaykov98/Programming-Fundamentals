int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
int firstOperation = AddSum(n1, n2);
int secondOperation = SubtractSum(firstOperation, n3);
Console.WriteLine(secondOperation);

static int AddSum(int n1, int n2)
{
    return n1 + n2;
}

static int SubtractSum(int n1, int n2)
{
    return n1 - n2;
}