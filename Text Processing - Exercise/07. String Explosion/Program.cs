string input = Console.ReadLine();
int bombPower = 0;
bool stringEnded = false;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '>')
    {
        bombPower = int.Parse(input[i + 1].ToString());

        for (int j = 0; j < bombPower; j++)
        {
            if (i + 1 >= input.Length)
            {
                stringEnded = true;
                break;
            }

            if (input[i + 1] != '>')
            {
                input = input.Remove(i + 1, 1);
            }
            else
            {
                i++;
                bombPower += int.Parse(input[i + 1].ToString());
                j--;
            }
        }
    }

    if (stringEnded)
    {
        break;
    }
}

Console.WriteLine(input);