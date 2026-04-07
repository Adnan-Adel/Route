namespace LibrarySystem.Models;

internal class Librarian : LibraryUser
{
    public string? LibrarianId { get; private set; }

    public decimal Salary { get; private set; }

    public DateOnly HireDate { get; private set; }

    public Librarian(string name, string phone, string librarianId, decimal salary, DateOnly hireDate)
    : base(name, phone)
    {
        LibrarianId = librarianId;
        Salary = salary;
        HireDate = hireDate;
    }

    public override string DisplayString()
    {
        return $@"ID: {LibrarianId}
Name: {Name}
Phone: {Phone}
Salary: {Salary:C}
Hired: {HireDate:dd/MM/yyyy}";
    }
}
