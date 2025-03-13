string[] phrases =
{
    "Excellent product.",
    "Such a great product.",
    "I always use that product.",
    "Best product of its category.",
    "Exceptional product.",
    "I can't live without this product."
};

string[] events =
{   
    "Now I feel good.",
    "I have succeeded with this product.",
    "Makes miracles. I am happy of the results!",
    "I cannot believe but now I feel awesome.",
    "Try it yourself, I am very satisfied.",
    "I feel great!"
};

string[] authors =
{
    "Diana",
    "Petya",
    "Stella",
    "Elena",
    "Katya",
    "Iva",
    "Annie",
    "Eva"
};

string[] cities =
{
    "Burgas",
    "Sofia",
    "Plovdiv",
    "Varna",
    "Ruse"
};

int n = int.Parse(Console.ReadLine());

Random random = new Random();

for (int i = 0; i < n; i++)
{
    int currentPhrase = random.Next(phrases.Length);
    int currentEvent = random.Next(events.Length);
    int currentAuthor = random.Next(authors.Length);
    int currentCity = random.Next(cities.Length);

    Console.WriteLine($"{phrases[currentPhrase]} {events[currentEvent]} {authors[currentAuthor]} – {cities[currentCity]}.");
}