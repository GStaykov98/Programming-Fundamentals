using System.Text;

string[] input = Console.ReadLine().Split();
StringBuilder sb = new StringBuilder();

for (int i = 0; i < input.Length; i++)
{
    string currentWord = input[i];
    int n = currentWord.Length;

    for (int j = 0; j < n; j++)
    {
        sb.Append(currentWord);
    }
}

Console.WriteLine(sb);