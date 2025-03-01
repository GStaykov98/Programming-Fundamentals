string input;

while ((input = Console.ReadLine()) != "END")
{
    int number = int.Parse(input);
    int reversedNumber = ReverseNumber(number);

    if (reversedNumber == number)
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine("false");
    }
}


static int ReverseNumber(int number)
{
    string numberToString = number.ToString();
    string reversedNumber = string.Empty;

    for (int i = numberToString.Length - 1; i >= 0; i--)
    {
        reversedNumber += numberToString[i];
    }

    return int.Parse(reversedNumber);
}