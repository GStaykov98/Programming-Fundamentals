string type = Console.ReadLine();
string input = Console.ReadLine();

if (type == "int")
{
    int number = int.Parse(input) * 2;
    Console.WriteLine(number);
}
else if (type == "real")
{
    double number = double.Parse(input) * 1.5;
    Console.WriteLine($"{number:f2}");
}
else if (type == "string")
{
    Console.WriteLine($"${input}$");
}