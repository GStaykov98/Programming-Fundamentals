string[] users = Console.ReadLine().Split(", ");

foreach (string user in users)
{
    if (IsUsernameValid(user))
    {
        Console.WriteLine(user);
    }
}

static bool IsUsernameValid(string username)
{
    bool isValid = false;

    if (username.Length > 3 && username.Length < 16)
    {
        isValid = true;

        for (int i = 0; i < username.Length; i++)
        {
            if (!char.IsLetterOrDigit(username[i]) &&
                username[i] != '-' && 
                username[i] != '_')
            {
                isValid = false;
                break;
            }
        }
    }
    
    return isValid;
}