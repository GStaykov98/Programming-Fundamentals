string[] input = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();

foreach (var line in input)
{
    Console.WriteLine(line);
}