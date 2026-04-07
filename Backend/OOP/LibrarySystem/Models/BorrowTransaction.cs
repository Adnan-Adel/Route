using LibrarySystem.Contracts;

namespace LibrarySystem.Models;

internal class BorrowTransaction : IDisplayable
{
    private static int _counter = 1000;
    private const decimal FinePerDay = 10M;
    private const string DateFormat = "dd/MM/yyyy";

    public int TransactionId { get; private set; }
    public Member Member { get; private set; }
    public BookCopy BookCopy { get; private set; }
    public DateOnly BorrowDate { get; set; }
    public DateOnly DueDate { get; set; }
    public DateOnly? ReturnDate { get; set; }

    public BorrowTransaction(Member member, BookCopy bookCopy, int loanDays)
    {
        TransactionId = ++_counter; //1001
        Member = member;
        BookCopy = bookCopy;
        BorrowDate = DateOnly.FromDateTime(DateTime.Today); // 17/03/2026
        DueDate = DateOnly.FromDateTime(DateTime.Today.AddDays(loanDays));
        ReturnDate = null;
    }

    public bool IsReturend()
        => ReturnDate.HasValue;

    public decimal CalculateFine()
    {
        DateOnly Effective = ReturnDate ?? DateOnly.FromDateTime(DateTime.Today);
        int overdueDays = Effective.DayNumber - DueDate.DayNumber;
        return overdueDays > 0 ? overdueDays * FinePerDay : 0;
    }

    public decimal CalculateFine(DateOnly returnDate)
    {
        int overdueDays = returnDate.DayNumber - DueDate.DayNumber;
        return overdueDays > 0 ? overdueDays * FinePerDay : 0;
    }

    public void MarkReturened(DateOnly returnDate)
        => ReturnDate = returnDate;

    public string DisplayString()
    {

        string Status = ReturnDate.HasValue ? "Returend" : "Active";
        decimal Fine = CalculateFine();
        string ReturnInfo = ReturnDate.HasValue ? ReturnDate.Value.ToString(DateFormat) : "Not Returned Yet !";
        string FineL = Fine > 0 ? $"{Fine:F2} EGP" : "None";



        return $@"── Transaction #{TransactionId} ──────────────
                    Book      : {BookCopy.Book.Title}
                    Copy ID   : {BookCopy.CopyId}
                    Borrowed  : {BorrowDate.ToString(DateFormat)}
                    Due       : {DueDate.ToString(DateFormat)}
                    Returned  : {ReturnInfo}
                    Status    : {Status}
                    Fine      : {FineL}";
    }
}
