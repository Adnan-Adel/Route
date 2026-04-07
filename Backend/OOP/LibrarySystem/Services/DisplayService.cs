using ConsoleTheme;
using LibrarySystem.Models;

namespace LibrarySystem.Services;

internal class DisplayService
{
    public void ShowBranchInfo(LibraryBranch branch)
    {
        ThemeHelper.PrintHeader("LIBRARY BRANCH INFO");
        Console.WriteLine(branch.DisplayString());
    }

    public void ShowAllUsers(LibraryBranch branch)
    {
        ThemeHelper.PrintHeader("All Registered Users");
        IReadOnlyList<LibraryUser> users = branch.Users;
        for (int i = 0; i < users.Count; i++)
        {
            string header = users[i] is Librarian ? "LIBRARIAN PROFILE" : "MEMBER PROFILE";
            ThemeHelper.PrintSectionTitle(header);
            Console.WriteLine(users[i].DisplayString());
        }
    }

    public void ShowAvailableCopies(LibraryBranch branch)
    {
        ThemeHelper.PrintHeader("Available Book Copies:");
        List<BookCopy> available = branch.GetAvailableCopies();
        if (available.Count == 0)
        {
            ThemeHelper.PrintWarning("No Avalaible Copies Found !");
            return;
        }

        for (int i = 0; i < available.Count; i++)
            Console.WriteLine(available[i].DisplayString());
    }

    public void ShowAllCopies(LibraryBranch branch)
    {
        ThemeHelper.PrintHeader("ALL BOOK COPIES");
        if (branch.Copies.Count == 0)
        {
            ThemeHelper.PrintWarning("No book copies found.");
            return;
        }
        for (int i = 0; i < branch.Copies.Count; i++)
            Console.WriteLine(branch.Copies[i].DisplayString());
    }

    public void ShowMemberHistory(Member member)
    {
        ThemeHelper.PrintSectionTitle($"Borrowing History for {member.Name}:");
        Console.WriteLine(member.GetHistoryDisplayString());
    }

    public void ShowBorrowSuccess(BookCopy copy, Member member)
    {
        ThemeHelper.PrintSuccess($"Copy [{copy.CopyId}] \"{copy.Book.Title}\" borrowed by {member.Name}.");
        ThemeHelper.PrintSuccess($"Due date: {copy.ActiveTransaction!.DueDate:dd/MM/yyyy}");
    }

    public void ShowReturnSuccess(BookCopy copy, decimal fine)
    {
        ThemeHelper.PrintSuccess($"Copy [{copy.CopyId}]: {copy.Book.Title} returned.");
        if (fine > 0)
            ThemeHelper.PrintWarning($"Late return fine: {fine:F2} EGP");
        else
            ThemeHelper.PrintSuccess("Returned on time. No fine.");
    }

    public void ShowRegistrationSuccess(Member member)
    {
        ThemeHelper.PrintSuccess($"Member: {member.Name} - [{member.MembershipId}] registered.");
    }

    public void ShowAddCopySuccess(BookCopy copy)
    {
        ThemeHelper.PrintSuccess($"Copy [{copy.CopyId}] - {copy.Book.Title}: added to branch.");
    }
}
