List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] arr = input.Split();
    string command = arr[0];

    if (command == "Delete")
    {
        int element = int.Parse(arr[1]);

        nums.RemoveAll(x => x == element);
    }
    else if (command == "Insert")
    {
        int element = int.Parse(arr[1]);
        int position = int.Parse(arr[2]);

        nums.Insert(position, element);
    }
}

Console.WriteLine(string.Join(" ", nums));