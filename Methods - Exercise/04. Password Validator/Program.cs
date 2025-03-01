string password = Console.ReadLine();
bool passwordIsValid = true;

if (!CheckLength(password))
{
    passwordIsValid = false;
    Console.WriteLine("Password must be between 6 and 10 characters");
}
if (!CheckIfOnlyLettersAndDigits(password))
{
	passwordIsValid = false;
    Console.WriteLine("Password must consist only of letters and digits");
}
if (!CheckDigitCount(password))
{
	passwordIsValid = false;
    Console.WriteLine("Password must have at least 2 digits");
}

if (passwordIsValid)
{
    Console.WriteLine("Password is valid");
}


static bool CheckLength(string input)
{
	if (input.Length >= 6 && input.Length <= 10)
	{
		return true;
	}
	return false;
}

static bool CheckIfOnlyLettersAndDigits(string input)
{
	for (int i = 0; i < input.Length; i++)
	{
		if (!char.IsLetter(input[i]) && !char.IsDigit(input[i]))
		{
			return false;
		}
	}
	return true;
}

static bool CheckDigitCount(string input)
{
	int digitCount = 0;

	for (int i = 0; i < input.Length; i++)
	{
		if (char.IsDigit(input[i]))
		{
			digitCount++;
		}
	}

	if (digitCount >= 2)
	{
		return true;
	}
	else
	{
		return false;
	}

}