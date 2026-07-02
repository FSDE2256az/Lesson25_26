namespace _1.Streams.Models;

public class Book
{
    public int Id { get; set; }
    public string AuthorName { get; set; }
    public string Name { get; set; }
    public string Genre { get; set; }


    public Book(int id, string authorName, string name, string genre)
    {
        Id = id;
        AuthorName = authorName;
        Name = name;
        Genre = genre;
    }


    public override string ToString()
    => @$"
Id: {Id}
AuthorName: {AuthorName}
Name: {Name}
Genre: {Genre}
";


}
