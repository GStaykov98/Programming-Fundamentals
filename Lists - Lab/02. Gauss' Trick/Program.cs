List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
int iterations = numbers.Count / 2;

for (int i = 0; i < iterations; i++)
{
    numbers[i] += numbers[numbers.Count - 1];
    numbers.RemoveAt(numbers.Count - 1);
}

Console.WriteLine(string.Join(" ", numbers));