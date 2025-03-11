int n = int.Parse(Console.ReadLine());
List<Song> songs = new();

for (int i = 0; i < n; i++)
{
    string[] currentSong = Console.ReadLine().Split('_');
    string type = currentSong[0];
    string name = currentSong[1];
    string time = currentSong[2];

    Song song = new Song
    {
        Name = name,
        Time = time,
        TypeList = type
    };

    songs.Add(song);
}

string typeList = Console.ReadLine();

if (typeList == "all")
{
    foreach (var song in songs)
    {
        Console.WriteLine(song.Name);
    }
}
else
{
    foreach(var song in songs.Where(x => x.TypeList == typeList))
    {
        Console.WriteLine(song.Name);
    }
}

class Song
{
    public string TypeList { get; set; }

    public string Name { get; set; }

    public string Time { get; set; }
}