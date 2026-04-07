using System.Text;

namespace LibrarySystem.Models;

internal class Member : LibraryUser
{
    private static int _counter = 1;
    public string MembershipId { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Email { get; set; }

    public DateOnly MembershipDate { get; set; }

    private List<BorrowTransaction> _transactions = new();

    public IReadOnlyList<BorrowTransaction> Transactions => _transactions;

    public Member(string name, string phone, DateOnly? dateOfBirth, string? email, DateOnly membershipDate)
    : base(name, phone)
    {
        MembershipId = $"MEM-{_counter++:D3}";
        DateOfBirth = dateOfBirth;
        Email = email;
        MembershipDate = membershipDate;
    }

    public Member(string name, string phone) : this(name, phone, null, null, DateOnly.FromDateTime(DateTime.Today))
    {

    }

    // ---------------- Methods -------------
    public void AddTransaction(BorrowTransaction t) => _transactions.Add(t);

    public string GetHistoryDisplayString()
    {
        if (Transactions.Count == 0)
            return "No Transaction Found!";

        var sb = new StringBuilder();
        for (int i = 0; i < Transactions.Count; i++)
        {
            sb.AppendLine(Transactions[i].DisplayString());
        }
        return sb.ToString();
    }

    public override string DisplayString() => $@"ID      : {MembershipId}
                                                Name    : {Name}
                                                Phone   : {Phone}
                                                Email   : {Email ?? "N/A"}
                                                Joined  : {MembershipDate:dd/MM/yyyy}
                                                Borrows : {Transactions.Count}";
}
