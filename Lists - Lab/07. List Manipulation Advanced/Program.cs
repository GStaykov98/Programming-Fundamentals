List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
string input;
bool madeChanges = false;

while ((input = Console.ReadLine()) != "end")
{
    string[] inputArr = input.Split();
    string command = inputArr[0];

    if (command == "Add")
    {
        int number = int.Parse(inputArr[1]);
        numbers.Add(number);
        madeChanges = true;
    }
    else if (command == "Remove")
    {
        int number = int.Parse(inputArr[1]);
        numbers.Remove(number);
        madeChanges = true;
    }
    else if (command == "RemoveAt")
    {
        int index = int.Parse(inputArr[1]);
        numbers.RemoveAt(index);
        madeChanges = true;
    }
    else if (command == "Insert")
    {
        int number = int.Parse(inputArr[1]);
        int index = int.Parse(inputArr[2]);
        numbers.Insert(index, number);
        madeChanges = true;
    }
    else if (command == "Contains")
    {
        int number = int.Parse(inputArr[1]);

        if (numbers.Contains(number))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (command == "PrintEven")
    {
        var outputList = new List<int>();

        foreach (int number in numbers.Where(x => x % 2 == 0))
        {
            outputList.Add(number);
        }

        Console.WriteLine(string.Join(" ", outputList));
    }
    else if (command == "PrintOdd")
    {
        var outputList = new List<int>();

        foreach (int number in numbers.Where(x => x % 2 != 0))
        {
            outputList.Add(number);
        }

        Console.WriteLine(string.Join(" ", outputList));
    }
    else if (command == "GetSum")
    {
        Console.WriteLine(numbers.Sum());
    }
    else if (command == "Filter")
    {
        string condition = inputArr[1];
        int number = int.Parse(inputArr[2]);
        var outputList = new List<int>();

        switch (condition)
        {
            case ">":
                outputList = numbers.Where(x => x > number).ToList();
                break;
            case "<":
                outputList = numbers.Where(x => x < number).ToList();
                break;
            case ">=":
                outputList = numbers.Where(x => x >= number).ToList();
                break;
            case "<=":
                outputList = numbers.Where(x => x <= number).ToList();
                break;

        }

        Console.WriteLine(string.Join(" ", outputList));
    }
}

if (madeChanges)
{
    Console.WriteLine(string.Join(" ", numbers));
}