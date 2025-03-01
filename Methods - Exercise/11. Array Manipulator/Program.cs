int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] arr = input.Split();
    string command = arr[0];

    switch (command)
    {
        case "exchange":

            int index = int.Parse(arr[1]) + 1;

            if (index < 0 || index > numbers.Length)
            {
                Console.WriteLine("Invalid index");
                continue;
            }
            numbers = ExchangeNumbers(numbers, index);

            break;
        case "max":

            if (arr[1] == "even")
            {
                GetMaxEvenNumberIndex(numbers);
            }
            else
            {
                GetMaxOddNumberIndex(numbers);
            }

            break;

        case "min":

            if (arr[1] == "even")
            {
                GetMinEvenNumberIndex(numbers);
            }
            else
            {
                GetMinOddNumberIndex(numbers);
            }

            break;

        case "first":

            int count = int.Parse(arr[1]);

            if (count < 0 || count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                continue;
            }

            if (arr[2] == "even")
            {
                GetFirstEven(numbers, count);
            }
            else
            {
                GetFirstOdd(numbers, count);
            }

            break;

        case "last":

            int countLast = int.Parse(arr[1]);

            if (countLast < 0 || countLast > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                continue;
            }

            if (arr[2] == "even")
            {
                GetLastEven(numbers, countLast);
            }
            else
            {
                GetLastOdd(numbers, countLast);
            }

            break;

    }
}

Console.WriteLine($"[{string.Join(", ", numbers)}]");


static int[] ExchangeNumbers(int[] arr, int index)
{
    for (int i = 0; i < index; i++)
    {
        int firstElement = arr[0];

        for (int j = 0; j < arr.Length - 1; j++)
        {
            arr[j] = arr[j + 1];
        }

        arr[arr.Length - 1] = firstElement;
    }

    return arr;
}

static void GetMaxEvenNumberIndex(int[] arr)
{
    int index = 0;
    int maxNumber = int.MinValue;
    bool isFound = false;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0 && arr[i] >= maxNumber)
        {
            maxNumber = arr[i];
            index = i;
            isFound = true;
        }
    }

    if (isFound)
    {
        Console.WriteLine(index);
    }
    else
    {
        Console.WriteLine("No matches");
    }
}

static void GetMaxOddNumberIndex(int[] arr)
{
    int index = 0;
    int maxNumber = int.MinValue;
    bool isFound = false;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0 && arr[i] >= maxNumber)
        {
            maxNumber = arr[i];
            index = i;
            isFound = true;
        }
    }

    if (isFound)
    {
        Console.WriteLine(index);
    }
    else
    {
        Console.WriteLine("No matches");
    }
}

static void GetMinEvenNumberIndex(int[] arr)
{
    int index = 0;
    int minNumber = int.MaxValue;
    bool isFound = false;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0 && arr[i] <= minNumber)
        {
            minNumber = arr[i];
            index = i;
            isFound = true;
        }
    }

    if (isFound)
    {
        Console.WriteLine(index);
    }
    else
    {
        Console.WriteLine("No matches");
    }
}

static void GetMinOddNumberIndex(int[] arr)
{
    int index = 0;
    int minNumber = int.MaxValue;
    bool isFound = false;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0 && arr[i] <= minNumber)
        {
            minNumber = arr[i];
            index = i;
            isFound = true;
        }
    }

    if (isFound)
    {
        Console.WriteLine(index);
    }
    else
    {
        Console.WriteLine("No matches");
    }
}

static void GetFirstEven(int[] arr, int count)
{
    string numbers = string.Empty;
    int foundCount = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (foundCount < count)
        {
            if (arr[i] % 2 == 0)
            {
                foundCount++;
                numbers += arr[i];
            }
        }
    }

    int[] newArray = new int[foundCount];

    if (foundCount == 0)
    {
        Console.WriteLine("[]");
    }
    else
    {
        for (int i = 0; i < foundCount; i++)
        {
            newArray[i] = int.Parse(numbers[i].ToString());
        }

        Console.WriteLine($"[{string.Join(", ", newArray)}]");
    }
}

static void GetFirstOdd(int[] arr, int count)
{
    string numbers = string.Empty;
    int foundCount = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (foundCount < count)
        {
            if (arr[i] % 2 != 0)
            {
                foundCount++;
                numbers += arr[i];
            }
        }
    }

    int[] newArray = new int[foundCount];

    if (foundCount == 0)
    {
        Console.WriteLine("[]");
    }
    else
    {
        for (int i = 0; i < foundCount; i++)
        {
            newArray[i] = int.Parse(numbers[i].ToString());
        }

        Console.WriteLine($"[{string.Join(", ", newArray)}]");
    }
}

static void GetLastEven(int[] arr, int count)
{
    string numbers = string.Empty;
    int foundCount = 0;

    for (int i = arr.Length - 1; i >= 0; i--)
    {
        if (foundCount < count)
        {
            if (arr[i] % 2 == 0)
            {
                foundCount++;
                numbers += arr[i];
            }
        }
    }

    int[] newArray = new int[foundCount];

    if (foundCount == 0)
    {
        Console.WriteLine("[]");
    }
    else
    {
        for (int i = 0; i < foundCount; i++)
        {
            newArray[i] = int.Parse(numbers[i].ToString());
        }

        Console.WriteLine($"[{string.Join(", ", newArray)}]");
    }
}

static void GetLastOdd(int[] arr, int count)
{
    string numbers = string.Empty;
    int foundCount = 0;

    for (int i = arr.Length - 1; i >= 0; i--)
    {
        if (foundCount < count)
        {
            if (arr[i] % 2 != 0)
            {
                foundCount++;
                numbers += arr[i];
            }
        }
    }

    int[] newArray = new int[foundCount];

    if (foundCount == 0)
    {
        Console.WriteLine("[]");
    }
    else
    {
        for (int i = 0; i < foundCount; i++)
        {
            newArray[i] = int.Parse(numbers[i].ToString());
        }

        Console.WriteLine($"[{string.Join(", ", newArray)}]");
    }
}