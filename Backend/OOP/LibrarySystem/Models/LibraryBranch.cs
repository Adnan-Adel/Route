using LibrarySystem.Contracts;
using LibrarySystem.Extensions;

namespace LibrarySystem.Models;


internal class LibraryBranch : IDisplayable
{

    public string BranchId { get; private set; } = null!;
    public string BranchName { get; private set; } = null!;
    public string Address { get; private set; } = null!;
    public string Phone { get; private set; } = null!;
    public string OpeningHours { get; private set; } = null!;
    public Librarian Manager { get; private set; } = null!;

    private readonly List<Member> _members = new();
    private readonly List<BookCopy> _copies = new();
    public IReadOnlyList<Member> Members => _members;
    public IReadOnlyList<BookCopy> Copies => _copies;

    // Return All Users [Librarins , Members]
    public IReadOnlyList<LibraryUser> Users
    {
        get
        {
            List<LibraryUser> users = new();
            users.Add(Manager);
            for (int i = 0; i < _members.Count; i++)
            {
                users.Add(_members[i]);
            }
            return users;
        }
    }


    public LibraryBranch(string branchId, string branchName, string address, string phone, string openingHours, Librarian manager)
    {
        BranchId = branchId;
        BranchName = branchName;
        Address = address;
        Phone = phone;
        OpeningHours = openingHours;
        Manager = manager;
    }


    public Member RegisterMember(string name, string phone)
    {
        var member = new Member(name, phone);
        _members.Add(member);
        return member;
    }

    // MEM-001
    // mem-001
    // MeM-001
    public Member FindMember(string membershipID)
    {
        string id = membershipID.NormalizeID();

        for (int i = 0; i < _members.Count; i++)
        {
            if (_members[i].MembershipId == id)
                return _members[i];
        }
        throw new InvalidOperationException("Member Not Found !");
    }

    public BookCopy FindCopy(string copyId)
    {
        string id = copyId.NormalizeID();
        for (int i = 0; i < _copies.Count; i++)
        {
            if (_copies[i].CopyId == id)
                return _copies[i];
        }
        throw new InvalidOperationException("Book Copy Not Found !");

    }

    public void AddBookCopy(BookCopy cpy)
    {
        _copies.Add(cpy);
    }

    public List<BookCopy> GetAvailableCopies()
    {
        List<BookCopy> availableCopies = new();
        for (int i = 0; i < _copies.Count; i++)
        {
            if (_copies[i].IsAvailable())
                availableCopies.Add(_copies[i]);
        }
        return availableCopies;
    }

    public string DisplayString() => $@"ID : {BranchId}
                                        Name : {BranchName}
                                        Address : {Address}
                                        Phone : {Phone}
                                        Opening Hours : {OpeningHours}
                                        Manager : {Manager.Name}
                                        Total Members : {_members.Count}
                                        Total Book Copies : {_copies.Count}";
}
