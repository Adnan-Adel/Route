using LibrarySystem.Contracts;

namespace LibrarySystem.Models;

internal abstract class LibraryUser : IDisplayable
{
    public string Name { get; protected set; }

    public string Phone { get; protected set; }

    public LibraryUser(string name, string phone)
    {
        Name = name;
        Phone = phone;
    }

    public abstract string DisplayString();
}
