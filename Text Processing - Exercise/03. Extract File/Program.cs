string[] input = Console.ReadLine().Split(@"\");
string[] nameAndExtension = input[input.Length - 1].Split('.');
string fileName = nameAndExtension[0];
string fileExtension = nameAndExtension[1];

Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {fileExtension}");