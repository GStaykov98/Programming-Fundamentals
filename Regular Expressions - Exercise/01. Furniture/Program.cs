using System.Text.RegularExpressions;

Regex regex = new Regex(@">>(?<product>[A-z]+)<<(?<price>\d+(.*\d+))!(?<quantity>\d+)");
double totalPrice = 0;
List<string> products = new();
string input;

while ((input = Console.ReadLine()) != "Purchase")
{
    Match match = regex.Match(input);

    if (match.Success)
    {
        string product = match.Groups["product"].Value;
        double price = double.Parse(match.Groups["price"].Value);
        int quantity = int.Parse(match.Groups["quantity"].Value);

        products.Add(product);
        totalPrice += price * quantity;
    }
}

Console.WriteLine("Bought furniture:");
foreach (string product in products)
{
    Console.WriteLine(product);
}
Console.WriteLine($"Total money spend: {totalPrice:f2}");