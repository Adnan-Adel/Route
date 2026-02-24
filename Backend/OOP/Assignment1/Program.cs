namespace OOPAssignment1
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("========== OOP Assignment - Part 01 ==========\n");

            // ==================== Q1: Class vs Struct ====================
            Console.WriteLine("==================== Q1: Class vs Struct ====================");
            Console.WriteLine("--- Classes (Reference Types) ---\n");

            Person person1 = new Person { Name = "Ahmed", Age = 25 };
            Person person2 = person1;  // Copies REFERENCE (both point to same object)

            Console.WriteLine("Before modification:");
            Console.WriteLine($"Person1: {person1.Name}, {person1.Age}");
            Console.WriteLine($"Person2: {person2.Name}, {person2.Age}");

            person2.Name = "Mohamed";
            person2.Age = 30;

            Console.WriteLine("\nAfter modifying person2:");
            Console.WriteLine($"Person1: {person1.Name}, {person1.Age}");  // CHANGED (same reference)
            Console.WriteLine($"Person2: {person2.Name}, {person2.Age}");

            Console.WriteLine("\nBoth changed because classes are reference types.\n");

            Console.WriteLine("--- Structs (Value Types) ---\n");

            Point point1 = new Point { X = 3, Y = 4 };
            Point point2 = point1;  // Copies VALUE (independent copy)

            Console.WriteLine("Before modification:");
            Console.WriteLine($"Point1: X={point1.X}, Y={point1.Y}");
            Console.WriteLine($"Point2: X={point2.X}, Y={point2.Y}");

            point2.X = 5;
            point2.Y = 6;

            Console.WriteLine("\nAfter modifying point2:");
            Console.WriteLine($"Point1: X={point1.X}, Y={point1.Y}");  // UNCHANGED (independent copy)
            Console.WriteLine($"Point2: X={point2.X}, Y={point2.Y}");

            Console.WriteLine("\nPoint1 unchanged because structs are value types.\n");
            Console.WriteLine("=============================================================\n");

            // ==================== Q2: Public vs Private ====================
            Console.WriteLine("==================== Q2: Public vs Private ====================");

            Student student = new Student("Ahmed", 3.6);

            // PUBLIC - Can access from outside the class
            Console.WriteLine($"Student Name: {student.Name}");

            // PRIVATE - Cannot access from outside the class
            // Console.WriteLine($"Student GPA: {student.gpa}");

            // Use public method to access private data (controlled access)
            Console.WriteLine($"Student GPA: {student.GetGpa()}");

            Console.WriteLine("\nPublic: Accessible from anywhere");
            Console.WriteLine("Private: Only accessible within the class");
            Console.WriteLine("Use public methods for controlled access to private data\n");
            Console.WriteLine("===============================================================\n");

            // ==================== Q3: Creating Class Library ====================
            Console.WriteLine("==================== Q3: Creating Class Library ====================");
            Console.WriteLine("\nSteps to Create and Use a Class Library:\n");

            Console.WriteLine("Step 1: Create the Class Library Project");
            Console.WriteLine("  1. Open Visual Studio");
            Console.WriteLine("  2. Click 'Create a new project'");
            Console.WriteLine("  3. Search for 'Class Library'");
            Console.WriteLine("  4. Select 'Class Library (.NET or .NET Core)'");
            Console.WriteLine("  5. Name it (e.g., 'MathLibrary')");
            Console.WriteLine("  6. Click 'Create'\n");

            Console.WriteLine("Step 2: Write Code in the Class Library");
            Console.WriteLine("  - Create classes with reusable methods");
            Console.WriteLine("  - Make classes and methods public for external access\n");

            Console.WriteLine("Step 3: Build the Class Library");
            Console.WriteLine("  1. Right-click on the project in Solution Explorer");
            Console.WriteLine("  2. Click 'Build'");
            Console.WriteLine("  3. This creates a .dll file in bin/Debug folder\n");

            Console.WriteLine("Step 4: Create a Console App to Use the Library");
            Console.WriteLine("  - Add a new Console Application project to the solution\n");

            Console.WriteLine("Step 5: Add Reference to the Class Library");
            Console.WriteLine("  1. In Console App, right-click 'Dependencies'");
            Console.WriteLine("  2. Click 'Add Project Reference'");
            Console.WriteLine("  3. Check the box for your library (e.g., 'MathLibrary')");
            Console.WriteLine("  4. Click 'OK'\n");

            Console.WriteLine("Step 6: Use the Class Library");
            Console.WriteLine("  - Import namespace: using MathLibrary;");
            Console.WriteLine("  - Call methods: MathOperations.Add(5, 3);\n");
            Console.WriteLine("====================================================================\n");

            // ==================== Q4: What is Class Library ====================
            Console.WriteLine("==================== Q4: What is a Class Library? ====================");
            Console.WriteLine("\n--- Definition ---");
            Console.WriteLine("A Class Library is a collection of reusable classes, methods, and");
            Console.WriteLine("types compiled into a .dll (Dynamic Link Library) file. It contains");
            Console.WriteLine("code that can be shared across multiple applications without copying");
            Console.WriteLine("the source code.\n");

            Console.WriteLine("--- Why Use Class Libraries? ---");
            Console.WriteLine("\n1. Code Reusability");
            Console.WriteLine("   - Write once, use in multiple projects");
            Console.WriteLine("   - No need to copy-paste code\n");

            Console.WriteLine("2. Modularity & Organization");
            Console.WriteLine("   - Separate concerns into different libraries");
            Console.WriteLine("   - Keep projects organized and maintainable\n");

            Console.WriteLine("3. Maintainability");
            Console.WriteLine("   - Fix bugs in one place");
            Console.WriteLine("   - All projects automatically get the fix\n");

            Console.WriteLine("4. Encapsulation");
            Console.WriteLine("   - Hide complex implementation details");
            Console.WriteLine("   - Users only see simple, public interfaces\n");

            Console.WriteLine("5. Team Collaboration");
            Console.WriteLine("   - Different teams can work on different libraries");
            Console.WriteLine("   - Share common functionality easily\n");

            Console.WriteLine("--- Real-World Examples ---");
            Console.WriteLine("  • System.Math (built-in .NET library)");
            Console.WriteLine("  • Newtonsoft.Json (popular NuGet package)");
            Console.WriteLine("  • Entity Framework (database library)");
            Console.WriteLine("\n=======================================================================\n");


            Console.WriteLine("\n========== OOP Assignment - Part 02 - Movie Ticket Booking System ==========\n");
            Console.Write("Enter Moive Name: ");
            string? MovieName = Console.ReadLine();

            Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
            bool isParsed = int.TryParse(Console.ReadLine(), out int typeChoice);
            TicketType Type = typeChoice switch
            {
                0 => TicketType.Standard,
                1 => TicketType.VIP,
                2 => TicketType.IMAX,
                _ => TicketType.Standard
            };

            Console.Write("Enter Seat Row (A, B, C...): ");
            char row = char.ToUpper(Console.ReadLine()![0]);

            Console.Write("Enter Seat Number: ");
            isParsed = int.TryParse(Console.ReadLine(), out int seatNumber);

            SeatLocation seat = new SeatLocation { Row = row, Number = seatNumber };

            Console.Write("Enter Price: ");
            isParsed = double.TryParse(Console.ReadLine(), out double price);

            Ticket ticket = new Ticket(MovieName!, Type, seat, price);

            Console.Write("Enter Discount Amount: ");
            isParsed = double.TryParse(Console.ReadLine(), out double discount);

            Console.WriteLine("==== Ticket Info ====");
            ticket.PrintTicket();

            Console.WriteLine("==== After Discount ====");
            Console.WriteLine($"Discount Before: {discount:F2}");
            ticket.ApplyDiscount(ref discount);
            Console.WriteLine($"Discount After: {discount:F2}");

            ticket.PrintTicket();

        }
    }

    // Class - Reference Type (stored on Heap)
    class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }

    // Struct - Value Type (stored on Stack)
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    // Student class demonstrating access modifiers
    class Student
    {
        // PUBLIC - Accessible from anywhere
        public string? Name { get; set; }

        // PRIVATE - Only accessible within this class
        private double gpa { get; set; }

        // Constructor
        public Student(string? name, double studentGpa)
        {
            Name = name;
            gpa = studentGpa;
        }

        // PUBLIC method - Provides controlled access to private data
        public double GetGpa()
        {
            return gpa;
        }
    }
}
