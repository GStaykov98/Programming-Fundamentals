Dictionary<string, double[]> orders = new();
string input;

while ((input = Console.ReadLine()) != "buy")
{
    string[] tokens = input.Split();
    string product = tokens[0];
    double price = double.Parse(tokens[1]);
    double quantity = double.Parse(tokens[2]);

    if (!orders.ContainsKey(product))
    {
        orders.Add(product, new double[2]);
    }

    orders[product][0] = price;
    orders[product][1] += quantity;
}

foreach (var order in orders)
{
    Console.WriteLine($"{order.Key} -> {order.Value[0] * order.Value[1]:f2}");
}