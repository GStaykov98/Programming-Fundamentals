int n = int.Parse(Console.ReadLine());
bool isBalanced = false;
bool inBrackets = false;

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

	if (input == "(" && inBrackets == false)
	{
		inBrackets = true;

		if (isBalanced)
		{
			isBalanced = false;
		}
	}

	if (input == ")" && inBrackets == true)
	{
		isBalanced = true;
		inBrackets = false;
	}
}

if (inBrackets)
{
	isBalanced = false;
}

if (isBalanced)
{
    Console.WriteLine("BALANCED");
}
else
{
    Console.WriteLine("UNBALANCED");
}