namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== OOP Assignment 02 - Part 01 ==========\n");

            // ==================== Question 1 ====================
            Console.WriteLine("==================== Question 1 ====================");
            Console.WriteLine("BankAccount Class Analysis\n");

            Console.WriteLine("Given Code:");
            Console.WriteLine("public class BankAccount");
            Console.WriteLine("{");
            Console.WriteLine("    public string Owner;");
            Console.WriteLine("    public double Balance;");
            Console.WriteLine("    public void Withdraw(double amount)");
            Console.WriteLine("    {");
            Console.WriteLine("        Balance -= amount;");
            Console.WriteLine("    }");
            Console.WriteLine("}\n");

            Console.WriteLine("a) Problems with this design:\n");
            Console.WriteLine("Problem 1: Fields are PUBLIC");
            Console.WriteLine("   - Balance can be directly modified from outside the class");
            Console.WriteLine("   - Example: account.Balance = 999999; (bypasses all validation)");
            Console.WriteLine("   - Violates encapsulation - no control over data\n");

            Console.WriteLine("Problem 2: Withdraw method has NO VALIDATION");
            Console.WriteLine("   - Does not check if amount > 0");
            Console.WriteLine("   - Does not check if Balance >= amount (sufficient funds)");
            Console.WriteLine("   - Can result in negative balance");
            Console.WriteLine("   - Example: Withdraw(1000) when Balance = 500 → Balance becomes -500\n");

            Console.WriteLine("b) How to fix this class:\n");
            Console.WriteLine("Solution:");
            Console.WriteLine("   1. Make fields PRIVATE (Balance, Owner)");
            Console.WriteLine("   2. Create PUBLIC PROPERTIES with validation");
            Console.WriteLine("      - Owner: Cannot be null or empty");
            Console.WriteLine("      - Balance: Read-only from outside, only modifiable through methods");
            Console.WriteLine("   3. Add validation in Withdraw method:");
            Console.WriteLine("      - Check if amount > 0");
            Console.WriteLine("      - Check if Balance >= amount");
            Console.WriteLine("      - Return bool or throw exception on failure");
            Console.WriteLine("   4. Add Deposit method with validation\n");

            Console.WriteLine("c) Why exposing fields directly is bad practice:\n");
            Console.WriteLine("Reason 1: No Data Validation");
            Console.WriteLine("   - Can't enforce business rules (e.g., Balance >= 0)");
            Console.WriteLine("   - Invalid data can corrupt the object state\n");

            Console.WriteLine("Reason 2: No Control Over Access");
            Console.WriteLine("   - Can't make a field read-only or write-only");
            Console.WriteLine("   - Can't track who is reading/writing the data\n");

            Console.WriteLine("Reason 3: Breaking Changes");
            Console.WriteLine("   - If you later add validation, all existing code breaks");
            Console.WriteLine("   - Properties allow you to add logic without changing the interface\n");

            Console.WriteLine("Reason 4: Security Risk");
            Console.WriteLine("   - Sensitive data (like Balance) can be manipulated directly");
            Console.WriteLine("   - No audit trail or logging of changes\n");

            Console.WriteLine("=====================================================\n");

            // ==================== Question 2 ====================
            Console.WriteLine("==================== Question 2 ====================");
            Console.WriteLine("Fields vs Properties in C#\n");

            Console.WriteLine("--- Difference Between Field and Property ---\n");

            Console.WriteLine("FIELD:");
            Console.WriteLine("   - A variable that stores data directly");
            Console.WriteLine("   - Example: private string name;");
            Console.WriteLine("   - Typically private");
            Console.WriteLine("   - No built-in logic or validation\n");

            Console.WriteLine("PROPERTY:");
            Console.WriteLine("   - Acts like a field but uses get/set accessors");
            Console.WriteLine("   - Example: public string Name { get; set; }");
            Console.WriteLine("   - Can contain logic, validation, and calculations");
            Console.WriteLine("   - Can be read-only, write-only, or read-write");
            Console.WriteLine("   - Typically public (controlled access to private fields)\n");

            Console.WriteLine("--- Can a Property Contain Logic? ---");
            Console.WriteLine("YES! Properties can contain validation, calculations, and any logic.\n");

            Console.WriteLine("--- Example: Read-Only Property with Calculated Value ---\n");

            // Demonstration
            Person person = new Person("Ahmed", "Mohamed", 1995);

            Console.WriteLine($"First Name: {person.FirstName}");
            Console.WriteLine($"Last Name: {person.LastName}");
            Console.WriteLine($"Birth Year: {person.BirthYear}");
            Console.WriteLine($"Full Name (calculated): {person.FullName}");
            Console.WriteLine($"Age (calculated): {person.Age}");

            Console.WriteLine("\n- FullName and Age are read-only properties");
            Console.WriteLine("- They calculate values using other properties");
            Console.WriteLine("- No backing field needed - computed on demand\n");

            Console.WriteLine("=====================================================\n");

            // ==================== Question 3 ====================
            Console.WriteLine("==================== Question 3 ====================");
            Console.WriteLine("StudentRegister Class - Indexers\n");

            Console.WriteLine("Given Code:");
            Console.WriteLine("public class StudentRegister");
            Console.WriteLine("{");
            Console.WriteLine("    private string[] names = new string[5];");
            Console.WriteLine("    public string this[int index]");
            Console.WriteLine("    {");
            Console.WriteLine("        get { return names[index]; }");
            Console.WriteLine("        set { names[index] = value; }");
            Console.WriteLine("    }");
            Console.WriteLine("}\n");

            Console.WriteLine("--- a) What is `this[int index]` called? ---\n");
            Console.WriteLine("Answer: INDEXER");
            Console.WriteLine("\nPurpose:");
            Console.WriteLine("   - Allows objects to be accessed using array-like syntax");
            Console.WriteLine("   - Makes the class act like a collection");
            Console.WriteLine("   - Example: register[0] = \"Ahmed\"; (looks like an array)");
            Console.WriteLine("   - Provides controlled access to internal array/collection");
            Console.WriteLine("   - Syntax: this[parameter] { get; set; }\n");

            Console.WriteLine("--- b) What happens with `register[10] = \"Ali\";`? ---\n");
            Console.WriteLine("Problem:");
            Console.WriteLine("   - Array size is 5 (indices 0-4)");
            Console.WriteLine("   - Accessing index 10 throws IndexOutOfRangeException");
            Console.WriteLine("   - Application crashes if not handled\n");

            Console.WriteLine("Solution - Make Indexer Safer:");
            Console.WriteLine("   1. Add validation in both get and set");
            Console.WriteLine("   2. Check if index is within valid range");
            Console.WriteLine("   3. Return null or throw custom exception on invalid index\n");

            Console.WriteLine("Safe Implementation:");
            Console.WriteLine("public string this[int index]");
            Console.WriteLine("{");
            Console.WriteLine("    get");
            Console.WriteLine("    {");
            Console.WriteLine("        if (index >= 0 && index < names.Length)");
            Console.WriteLine("            return names[index];");
            Console.WriteLine("        return null; // or throw exception");
            Console.WriteLine("    }");
            Console.WriteLine("    set");
            Console.WriteLine("    {");
            Console.WriteLine("        if (index >= 0 && index < names.Length)");
            Console.WriteLine("            names[index] = value;");
            Console.WriteLine("        // else do nothing or throw exception");
            Console.WriteLine("    }");
            Console.WriteLine("}\n");

            Console.WriteLine("--- c) Can a class have multiple indexers? ---\n");
            Console.WriteLine("Answer: YES");
            Console.WriteLine("\nA class can have multiple indexers with:");
            Console.WriteLine("   - Different parameter types");
            Console.WriteLine("   - Different number of parameters\n");
            Console.WriteLine("=====================================================\n");

            // ==================== Question 4 ====================
            Console.WriteLine("==================== Question 4 ====================");
            Console.WriteLine("Order Class - Static Members\n");

            Console.WriteLine("Given Code:");
            Console.WriteLine("public class Order");
            Console.WriteLine("{");
            Console.WriteLine("    public static int TotalOrders = 0;");
            Console.WriteLine("    public string Item;");
            Console.WriteLine("");
            Console.WriteLine("    public Order(string item)");
            Console.WriteLine("    {");
            Console.WriteLine("        Item = item;");
            Console.WriteLine("        TotalOrders++;");
            Console.WriteLine("    }");
            Console.WriteLine("}\n");

            Console.WriteLine("--- a) What does `static` mean? Difference from `Item`? ---\n");

            Console.WriteLine("STATIC keyword meaning:");
            Console.WriteLine("   - Belongs to the CLASS itself, not to individual objects");
            Console.WriteLine("   - Shared across ALL instances of the class");
            Console.WriteLine("   - Only ONE copy exists in memory");
            Console.WriteLine("   - Accessed using the class name: Order.TotalOrders");
            Console.WriteLine("   - Exists even if no objects are created\n");

            Console.WriteLine("TotalOrders (STATIC field):");
            Console.WriteLine("   - Class-level: Belongs to Order class");
            Console.WriteLine("   - Shared: All Order objects share the same TotalOrders");
            Console.WriteLine("   - Access: Order.TotalOrders (using class name)");
            Console.WriteLine("   - Memory: Only 1 copy exists");
            Console.WriteLine("   - Purpose: Track data across all instances (e.g., count)\n");

            Console.WriteLine("Item (NON-STATIC/Instance field):");
            Console.WriteLine("   - Object-level: Each Order object has its own Item");
            Console.WriteLine("   - Independent: order1.Item ≠ order2.Item");
            Console.WriteLine("   - Access: order1.Item (using object reference)");
            Console.WriteLine("   - Memory: One copy per object");
            Console.WriteLine("   - Purpose: Store data specific to each instance\n");

            Console.WriteLine("--- b) Can static method access `Item` field? ---\n");

            Console.WriteLine("Answer: NO\n");

            Console.WriteLine("Reason:");
            Console.WriteLine("   - Static methods belong to the CLASS");
            Console.WriteLine("   - Instance fields (like Item) belong to OBJECTS");
            Console.WriteLine("   - Static methods don't know WHICH object's Item to access");
            Console.WriteLine("   - Static methods can ONLY access static members directly\n");
            Console.WriteLine("=====================================================\n");

        }
    }

    // Example class demonstrating read-only calculated properties
    class Person
    {
        // Private fields (backing fields)
        private string firstName;
        private string lastName;
        private int birthYear;

        // Constructor
        public Person(string first, string last, int year)
        {
            firstName = first;
            lastName = last;
            birthYear = year;
        }

        // Regular properties with validation
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    lastName = value;
            }
        }

        public int BirthYear
        {
            get { return birthYear; }
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                    birthYear = value;
            }
        }

        // READ-ONLY property that returns a CALCULATED value
        public string FullName => $"{firstName} {lastName}";

        // Another READ-ONLY calculated property
        public int Age => DateTime.Now.Year - birthYear;
    }
}
