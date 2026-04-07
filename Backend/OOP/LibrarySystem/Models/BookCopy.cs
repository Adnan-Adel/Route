using LibrarySystem.Contracts;

namespace LibrarySystem.Models;

internal enum CopyStatus
{
    Available,
    Borrowed,
    Damaged,
    Reserved
}

internal class BookCopy : IDisplayable, IBorrowable
{
    public string? CopyId { get; private set; }

    public string? Condition { get; private set; }

    public CopyStatus Status { get; private set; }

    public Book Book { get; private set; }

    public BorrowTransaction? ActiveTransaction { get; private set; }

    public BookCopy(string copyId, Book book, string condition = "Good")
    {
        CopyId = copyId;
        Condition = condition;
        Book = book;
        Status = CopyStatus.Available;
    }

    public bool IsAvailable() => Status == CopyStatus.Available;

    public void Borrow(Member member, int loanDays = 14)
    {
        if (!IsAvailable())
            throw new InvalidOperationException($"Copy : {CopyId} is Not Available !");

        Status = CopyStatus.Borrowed;
        ActiveTransaction = new BorrowTransaction(member, this, loanDays);
        member.AddTransaction(ActiveTransaction);
    }

    public decimal Return()
    {
        if (ActiveTransaction == null)
            throw new InvalidOperationException("No Active Transaction For This Copy !");

        if (Status != CopyStatus.Borrowed)
            throw new InvalidOperationException($"Copy : {CopyId} is Not Currently Borrowed !");

        ActiveTransaction.MarkReturened(DateOnly.FromDateTime(DateTime.Today));
        decimal Fine = ActiveTransaction.CalculateFine();
        Status = CopyStatus.Available;
        ActiveTransaction = null;

        return Fine;
    }

    public string DisplayString()
    {
        string avail = IsAvailable() ? "Available" : $"{Status}";
        return $"Copy [{CopyId}] — {Book.Title} | Condition: {Condition} | {avail}";
    }
}
