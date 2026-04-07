using ConsoleTheme;
using LibrarySystem.Extensions;
using LibrarySystem.Models;

namespace LibrarySystem.Services;

internal class LibraryService
{
    private readonly LibraryBranch _branch;
    private readonly DisplayService _display;

    public LibraryService(LibraryBranch branch, DisplayService display)
    {
        _branch = branch;
        _display = display;
    }

    public void HandleBorrow()
    {
        string memberId = ThemeHelper.Prompt("MEMBER ID").NormalizeID();
        Member member = _branch.FindMember(memberId);

        _display.ShowAvailableCopies(_branch);

        string copyID = ThemeHelper.Prompt("Copy ID to Borrow").NormalizeID();
        BookCopy copy = _branch.FindCopy(copyID);

        copy.Borrow(member);
        _display.ShowBorrowSuccess(copy, member);

    }

    public void HandleReturn()
    {
        string copyID = ThemeHelper.Prompt("Copy Id to Return").NormalizeID();
        BookCopy copy = _branch.FindCopy(copyID);

        decimal fine = copy.Return();

        _display.ShowReturnSuccess(copy, fine);
    }

    public void HandleHistory()
    {
        string memberID = ThemeHelper.Prompt("Member ID").NormalizeID();
        Member member = _branch.FindMember(memberID);
        _display.ShowMemberHistory(member);
    }

    public void HandleRegisterMember()
    {
        string name = ThemeHelper.Prompt("Full Name");

        string phone = ThemeHelper.Prompt("Phone Number");
        if (!phone.ContainsDigits())
            throw new InvalidOperationException("Wrong Phone Number");

        string email = ThemeHelper.Prompt("Email Address");
        if (!email.IsValidEmail())
            throw new InvalidOperationException("Wrong Email Address");

        Member member = _branch.RegisterMember(name, phone);

        _display.ShowRegistrationSuccess(member);
    }
}
