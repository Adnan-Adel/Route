using LibrarySystem.Contracts;

namespace LibrarySystem.Models;

internal class Book : IDisplayable
{
    public string? ISBN { get; private set; }
    public string? Title { get; private set; }
    public string? AuthorName { get; private set; }
    public string? Category { get; private set; }
    public int PublicationYear { get; private set; }

    public Book(string? isbn, string? title, string? authorName, string? category, int publicationYear)
    {
        ISBN = isbn;
        Title = title;
        AuthorName = authorName;
        Category = category;
        PublicationYear = publicationYear;
    }

    public Book(string isbn, string title) : this(isbn, title, "Unknown", "General", 0)
    {

    }


    public string DisplayString() => $"[{ISBN}] \"{Title}\" by {AuthorName} ({PublicationYear}) - {Category}";
}
