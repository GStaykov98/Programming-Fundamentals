using System.Text.RegularExpressions;

Regex regex = new Regex(@"%(?<customer>[A-Z][a-z]+)%<(?<product>[A-Za-z]+)>\|(?<count>\d+)\|[^0-9]*(?<price>\d+(.*\d+)?)\$");
double totalIncome = 0;
string input;

while ((input = Console.ReadLine()) != "end of shift")
{
    Match match = regex.Match(input);
    
    if (match.Success)
    {
        string name = match.Groups["customer"].Value;
        string product = match.Groups["product"].Value;
        int count = int.Parse(match.Groups["count"].Value);
        double price = double.Parse(match.Groups["price"].Value);

        totalIncome += price * count;
        Console.WriteLine($"{name}: {product} - {price * count:f2}");
    }
}

Console.WriteLine($"Total income: {totalIncome:f2}");