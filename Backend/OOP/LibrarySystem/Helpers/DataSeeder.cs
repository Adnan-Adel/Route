using LibrarySystem.Models;

namespace LibrarySystem.Helpers;

internal class DataSeeder
{
    public static LibraryBranch Seed()
    {
        Librarian manager = new("LIB-01", "Sara Ahmed", "01012345678", salary: 8500m, hireDate: new DateOnly(2019, 3, 15));

        LibraryBranch branch = new("BR-01", "City Library — Nasr City Branch", "15 Nasr Road, Nasr City, Cairo",
                                    "01012345678", "Sat–Thu: 09:00 AM – 09:00 PM", manager);



        branch.RegisterMember("Omar Samir", "01234567890");
        branch.RegisterMember("Ahmed Omar", "98745632");
        branch.RegisterMember("Mai Alaa", "8529674111");

        Book b1 = new("978-0-13-468599-1", "Clean Code",
                           "Robert C. Martin", "Software Engineering", 2008);

        Book b2 = new("978-0-13-235088-4", "The Pragmatic Programmer",
                           "David Thomas", "Software Engineering", 1999);

        Book b3 = new("978-0-06-112008-4", "To Kill a Mockingbird");

        BookCopy c1 = new("COPY-001", b1, "Good");
        BookCopy c2 = new("COPY-002", b1, "Fair");
        BookCopy c3 = new("COPY-003", b2, "Excellent");
        BookCopy c4 = new("COPY-004", b3, "Good");

        branch.AddBookCopy(c1);
        branch.AddBookCopy(c2);
        branch.AddBookCopy(c3);
        branch.AddBookCopy(c4);

        return branch;
    }

}
