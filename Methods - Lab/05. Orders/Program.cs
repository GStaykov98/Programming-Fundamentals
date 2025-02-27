string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

GetPrice(product, quantity);

static void GetPrice(string product, int quantity)
{
	double price = 0;

	switch (product)
	{
		case "coffee":
			price = quantity * 1.5;
			break;
		case "water":
			price = quantity * 1.0;
			break;
		case "coke":
			price = quantity * 1.4;
			break;
		case "snacks":
			price = quantity * 2.0;
			break;
	}

    Console.WriteLine($"{price:f2}");
}