int n = int.Parse(Console.ReadLine());
string numToString = n.ToString();
long sum = 0;

for (int i = 0; i < numToString.Length; i++)
{
    int currentDigit = int.Parse(numToString[i].ToString());
    sum += currentDigit;
}

Console.WriteLine(sum);