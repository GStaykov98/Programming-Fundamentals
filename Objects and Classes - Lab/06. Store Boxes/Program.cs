List<Box> boxes = new();
string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] inputArr = input.Split();
    int serialNumber = int.Parse(inputArr[0]);
    string itemName = inputArr[1];
    int itemQuantity = int.Parse(inputArr[2]);
    decimal itemPrice = decimal.Parse(inputArr[3]);

    Item currentItem = new Item
    {
        Name = itemName,
        Price = itemPrice
    };

    Box currentBox = new Box
    {
        SerialNumber = serialNumber,
        ItemQuantity = itemQuantity,
        Item = currentItem,
        PricePerBox = itemQuantity * itemPrice
    };

    boxes.Add(currentBox);
}

boxes = boxes.OrderByDescending(x => x.PricePerBox).ToList();

foreach (Box box in boxes)
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.PricePerBox:f2}");
}

class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Box
{
    public int SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public decimal PricePerBox { get; set; }
}