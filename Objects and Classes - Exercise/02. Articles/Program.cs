string[] tokens = Console.ReadLine().Split(", ");
string title = tokens[0];
string content = tokens[1];
string author = tokens[2];

Article article = new(title, content, author);

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(": ");
    string command = input[0];

    switch (command)
    {
        case "Edit":

            string newContent = input[1];
            article.Edit(newContent);

            break;

        case "ChangeAuthor":

            string newAuthor = input[1];
            article.ChangeAuthor(newAuthor);

            break;

        case "Rename":

            string newTitle = input[1];
            article.Rename(newTitle);

            break;
    }
}

Console.WriteLine(article.ToString());


public class Article
{
    public Article(string title, string content, string author)
    {
        this.Title = title;
        this.Content = content;
        this.Author = author;
    }

    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public void Edit(string newContent)
    {
        this.Content = newContent;
    }

    public void ChangeAuthor(string newAuthor)
    {
        this.Author = newAuthor;
    }

    public void Rename(string newName)
    {
        this.Title = newName;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}