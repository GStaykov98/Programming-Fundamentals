public class Program
{
    static void Main()
    {
        string valueType = Console.ReadLine();
        string firstValue = Console.ReadLine();
        string secondValue = Console.ReadLine();

        if (valueType == "int")
        {
            int n1 = int.Parse(firstValue);
            int n2 = int.Parse(secondValue);
            GetMax(n1, n2);
        }
        else if (valueType == "char")
        {
            char c1 = char.Parse(firstValue);
            char c2 = char.Parse(secondValue);
            GetMax(c1, c2);
        }
        else if (valueType == "string")
        {
            GetMax(firstValue, secondValue);
        }
    }


    static void GetMax(int a, int b)
    {
        if (a > b)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
    }

    static void GetMax(char a, char b)
    {
        if (a > b)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
    }

    static void GetMax(string a, string b)
    {
        if (a.CompareTo(b) > 0)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
    }
}