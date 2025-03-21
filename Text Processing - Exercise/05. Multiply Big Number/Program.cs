using System.Text;

string bigNumber = Console.ReadLine();
int multiplier = int.Parse(Console.ReadLine());
StringBuilder output = new();
int overflow = 0;

if (multiplier == 0)
{
    Console.WriteLine(0);
    return;
}

for (int i = bigNumber.Length - 1; i >= 0; i--)
{
    int currentNumber = int.Parse(bigNumber[i].ToString());

    int result = currentNumber * multiplier + overflow;
    int numberToAdd = result % 10;
    overflow = result / 10;

    output.Insert(0, numberToAdd);
}

if (overflow != 0)
{
    output.Insert(0, overflow);
}

Console.WriteLine(output);