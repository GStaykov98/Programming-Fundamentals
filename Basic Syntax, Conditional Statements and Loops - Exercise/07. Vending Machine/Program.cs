string input;
double totalCoinsInserted = 0;

while ((input = Console.ReadLine()) != "Start")
{
    double coin = double.Parse(input);

    if (coin == 0.1 ||
        coin == 0.2 ||
        coin == 0.5 ||
        coin == 1 ||
        coin == 2)
    {
        totalCoinsInserted += coin;
    }
    else
    {
        Console.WriteLine($"Cannot accept {coin}");
    }
}

while ((input = Console.ReadLine()) != "End")
{
    string product = input;
    double productPrice = 0;

    switch (product)
    {
        case "Nuts":

            productPrice = 2.0;

            if (totalCoinsInserted < productPrice)
            {
                Console.WriteLine("Sorry, not enough money");
            }
            else
            {
                Console.WriteLine($"Purchased {product.ToLower()}");
                totalCoinsInserted -= productPrice;
            }

            break;
        case "Water":

            productPrice = 0.7;

            if (totalCoinsInserted < productPrice)
            {
                Console.WriteLine("Sorry, not enough money");
            }
            else
            {
                Console.WriteLine($"Purchased {product.ToLower()}");
                totalCoinsInserted -= productPrice;
            }

            break;
        case "Crisps":

            productPrice = 1.5;

            if (totalCoinsInserted < productPrice)
            {
                Console.WriteLine("Sorry, not enough money");
            }
            else
            {
                Console.WriteLine($"Purchased {product.ToLower()}");
                totalCoinsInserted -= productPrice;
            }

            break;
        case "Soda":

            productPrice = 0.8;

            if (totalCoinsInserted < productPrice)
            {
                Console.WriteLine("Sorry, not enough money");
            }
            else
            {
                Console.WriteLine($"Purchased {product.ToLower()}");
                totalCoinsInserted -= productPrice;
            }

            break;
        case "Coke":

            productPrice = 1.0;

            if (totalCoinsInserted < productPrice)
            {
                Console.WriteLine("Sorry, not enough money");
            }
            else
            {
                Console.WriteLine($"Purchased {product.ToLower()}");
                totalCoinsInserted -= productPrice;
            }

            break;
        default:
            Console.WriteLine("Invalid product");
            break;
    }
}

Console.WriteLine($"Change: {totalCoinsInserted:f2}");