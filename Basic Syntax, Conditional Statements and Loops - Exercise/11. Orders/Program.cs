﻿int n = int.Parse(Console.ReadLine());
double total = 0;

for (int i = 0; i < n; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());

    double price = (days * capsulesCount) * pricePerCapsule;
    Console.WriteLine($"The price for the coffee is: ${price:f2}");
    total += price;
}

Console.WriteLine($"Total: ${total:f2}");