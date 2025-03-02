List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] inputArr = input.Split();
    string command = inputArr[0];

    if (command == "Add")
    {
        int number = int.Parse(inputArr[1]);
        numbers.Add(number);
    }
    else if (command == "Remove")
    {
        int number = int.Parse(inputArr[1]);
        numbers.Remove(number);
    }
    else if (command == "RemoveAt")
    {
        int index = int.Parse(inputArr[1]);
        numbers.RemoveAt(index);
    }
    else if (command == "Insert")
    {
        int number = int.Parse(inputArr[1]);
        int index = int.Parse(inputArr[2]);
        numbers.Insert(index, number);
    }
}

Console.WriteLine(string.Join(" ", numbers));