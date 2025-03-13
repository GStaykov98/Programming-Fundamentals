int n = int.Parse(Console.ReadLine());
List<Article> articles = new();

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split(", ");
    string title = tokens[0];
    string content = tokens[1];
    string author = tokens[2];

    Article currentArticle = new(title, content, author);

    articles.Add(currentArticle);
}

foreach (Article article in articles)
{
    Console.WriteLine(article.ToString());
}

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

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}