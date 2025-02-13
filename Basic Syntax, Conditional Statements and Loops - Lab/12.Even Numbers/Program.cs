int number = int.Parse(Console.ReadLine());
bool isEven = false;

while (!isEven)
{
    if (number % 2 == 0)
    {
        Console.WriteLine($"The number is: {Math.Abs(number)}");
        isEven = true;
    }
    else
    {
        Console.WriteLine("Please write an even number.");
        number = int.Parse(Console.ReadLine());
    }
}