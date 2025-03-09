List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
string input;

while ((input = Console.ReadLine()) != "End")
{
    string[] arr = input.Split();
    string command = arr[0];

    if (command == "Add")
    {
        int number = int.Parse(arr[1]);
        numbers.Add(number);
    }
    else if (command == "Insert")
    {
        int number = int.Parse(arr[1]);
        int index = int.Parse(arr[2]);

        if (index >= numbers.Count || index < 0)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            numbers.Insert(index, number);
        }
    }
    else if (command == "Remove")
    {
        int index = int.Parse(arr[1]);

        if (index >= numbers.Count || index < 0)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            numbers.RemoveAt(index);
        }
        
    }
    else if (command == "Shift")
    {
        string position = arr[1];
        int count = int.Parse(arr[2]);

        if (position == "left")
        {
            for (int i = 0; i < count; i++)
            {
                int firstNum = numbers[0];

                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Count - 1] = firstNum;
            }
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                int lastNum = numbers[numbers.Count - 1];

                for (int j = numbers.Count - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }

                numbers[0] = lastNum;
            }
        }
    }
}

Console.WriteLine(string.Join(" ", numbers));