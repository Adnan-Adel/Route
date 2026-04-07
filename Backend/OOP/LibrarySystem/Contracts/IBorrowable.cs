using LibrarySystem.Models;

namespace LibrarySystem.Contracts;

internal interface IBorrowable
{
    void Borrow(Member member, int loanDays = 14);

    decimal Return();

    bool IsAvailable();
}
