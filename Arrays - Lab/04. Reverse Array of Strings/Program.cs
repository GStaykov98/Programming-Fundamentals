string[] input = Console.ReadLine().Split();

input = input.Reverse().ToArray();

for (int i = 0; i < input.Length; i++)
{
    Console.Write(input[i] + " ");
}