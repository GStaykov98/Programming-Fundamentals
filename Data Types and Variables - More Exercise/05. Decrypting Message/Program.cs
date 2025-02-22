int key = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
string result = string.Empty;

for (int i = 0; i < n; i++)
{
    char currentChar = char.Parse(Console.ReadLine());

    char currentLetter = (char)(currentChar + key);
    result = result + currentLetter.ToString();
}

Console.WriteLine(result);